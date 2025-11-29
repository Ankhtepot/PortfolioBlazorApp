#!/bin/sh
set -e

echo "Applying EF Core migrations..."
dotnet Portfolio.BlazorApp.dll --migrate

exec dotnet Portfolio.BlazorApp.dll
