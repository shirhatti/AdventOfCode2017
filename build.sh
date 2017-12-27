#!/bin/bash

# Ensures exit code is returned
set -e

dotnet restore
dotnet build
cd test/AdventOfCode.Test
dotnet xunit
