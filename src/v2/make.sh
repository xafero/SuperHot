#!/bin/sh

dotnet build   SuperHot
dotnet test    SuperHot.UnitTests
dotnet pack    SuperHot           -o ../dist/v2

