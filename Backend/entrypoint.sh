#!/bin/sh
set -e

echo "Applying EF Core migrations..."
dotnet Backend.dll --migrate

exec dotnet Backend.dll
