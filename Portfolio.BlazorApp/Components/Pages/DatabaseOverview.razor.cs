using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Portfolio.BlazorApp.Data;
using Portfolio.BlazorApp.Data.Models;
using Portfolio.BlazorApp.Services;

namespace Portfolio.BlazorApp.Components.Pages;

public partial class DatabaseOverview
{
    private bool _loaded;
    private List<Item>? _items;
    private List<Player>? _players;
    private List<Hero>? _heroes;
    private List<Soldier>? _soldiers;

    private List<TableData> _tables = [];
    private const string TestEntityPrefix = "Entity of ";

    protected override async Task OnInitializedAsync()
    {
        await SetDbTablesLists();

        PageTitleState.SetTitle("Database Overview");
        _tables = GetTables().ToList();
        _loaded = true;
    }

    private async Task SetDbTablesLists()
    {
        _items = await Db.Items.AsNoTracking().ToListAsync();
        _players = await Db.Players.AsNoTracking().ToListAsync();
        _heroes = await Db.Heroes.AsNoTracking().ToListAsync();
        _soldiers = await Db.Soldiers.AsNoTracking().ToListAsync();
    }

    private IEnumerable<TableData> GetTables()
    {
        if (_items == null && _players == null && _heroes == null && _soldiers == null)
        {
            yield return new TableData("No data", new List<object>(), typeof(object));
            yield break;
        }

        yield return new TableData("Items", _items!, typeof(Item));
        yield return new TableData("Players", _players!, typeof(Player));
        yield return new TableData("Heroes", _heroes!, typeof(Hero));
        yield return new TableData("Soldiers", _soldiers!, typeof(Soldier));
    }

    private async Task OnAddEntity(Type entityType)
    {
        // Create a new instance of the entity
        object? newEntity = Activator.CreateInstance(entityType);
        if (newEntity is null)
            return;

        // Get DbSet<TEntity> dynamically: Db.Set<TEntity>()
        object? dbSetGeneric = typeof(AppDbContext)
            .GetMethod(nameof(Db.Set), Type.EmptyTypes)!
            .MakeGenericMethod(entityType)
            .Invoke(Db, null);

        if (dbSetGeneric is null)
            return;

        // Fill Random values for the new entity based on its type
        PropertyInfo[] properties = entityType.GetProperties();
        foreach (PropertyInfo propertyInfo in properties)
        {
            if (propertyInfo.Name == "Id") // Skip Id property
                continue;

            if (propertyInfo.PropertyType == typeof(string))
            {
                propertyInfo.SetValue(newEntity, propertyInfo.Name == "Name"
                    ? $"{TestEntityPrefix} {entityType.Name}"
                    : "Some String");
            }

            if (propertyInfo.PropertyType == typeof(int))
            {
                propertyInfo.SetValue(newEntity, 10.GetRandom());
            }
        }

        await Db.AddAsync(newEntity);
        await Db.SaveChangesAsync();
        await SetDbTablesLists();

        _tables = GetTables().ToList();
        StateHasChanged();
    }

    private async Task OnDeleteEntity(object row)
    {
        Type rowType = row.GetType();

        // Get the DbSet<> type for this entity type
        Type genericDbSetType = typeof(DbSet<>).MakeGenericType(rowType);
        // Cast DbContext.Set<T>() to DbSet<T>
        object? dbSetInstance = typeof(AppDbContext)
            .GetMethod(nameof(Db.Set), Type.EmptyTypes)!
            .MakeGenericMethod(rowType)
            .Invoke(Db, null);

        if (dbSetInstance == null) return;
        // Get the Remove method of DbSet<T>
        MethodInfo? removeMethod = genericDbSetType.GetMethod("Remove", [rowType]);
        if (removeMethod == null) return;

        // Load entity from DbContext to ensure it's being tracked
        PropertyInfo? keyProperty = rowType.GetProperty("Id");
        if (keyProperty == null) return;

        object? idValue = keyProperty.GetValue(row);

        // Use Find from DbSet<T> via reflection to get the tracked entity
        MethodInfo? findMethod = genericDbSetType.GetMethod("Find", [typeof(object[])]);
        object? trackedEntity = findMethod?.Invoke(dbSetInstance, [new object[] {idValue!}]);
        if (trackedEntity == null) return;

        // Invoke Remove(row)
        removeMethod.Invoke(dbSetInstance, [trackedEntity]);
        await Db.SaveChangesAsync();
        await SetDbTablesLists();

        _tables = GetTables().ToList();

        StateHasChanged();
    }
}