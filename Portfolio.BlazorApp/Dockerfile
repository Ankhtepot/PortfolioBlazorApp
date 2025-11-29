FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Portfolio.BlazorApp.csproj", "."]
RUN dotnet restore "Portfolio.BlazorApp.csproj"
COPY . .
#WORKDIR "/src"
RUN dotnet build "Portfolio.BlazorApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Portfolio.BlazorApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Portfolio.BlazorApp.dll"]
COPY entrypoint.sh .
RUN chmod +x entrypoint.sh
ENTRYPOINT ["./entrypoint.sh"]