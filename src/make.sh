#!/bin/sh

dotnet restore
dotnet build   --no-restore
dotnet test    --no-restore --no-build
dotnet pack    --no-restore            -o dist

