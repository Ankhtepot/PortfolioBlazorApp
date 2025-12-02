namespace Backend.Data.Models;

public class TableData(string tableName, IEnumerable<object> rows, Type itemType)
{
        public string TableName { get; set; } = tableName; 
        public IEnumerable<object> Rows { get; set; } = rows;
        public Type ItemType { get; set; } = itemType;
}