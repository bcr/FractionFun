# Overview

```csharp
/*
    Write a command line program in the language of your choice that will take operations on fractions as an input and produce a fractional result.

    Legal operators shall be *, /, +, - (multiply, divide, add, subtract).

    Operands and operators shall be separated by one or more spaces.

    Mixed numbers will be represented by whole_numerator/denominator. e.g. "3_1/4".

    Improper fractions and whole numbers are also allowed as operands.

    Example run
    ? 1/2 * 3_3/4
    = 1_7/8

    ? 2_3/8 + 9/8
    = 3_1/2
    */
```

## Setting up the projects

`$ dotnet new library -o Bcr.Fractions`
`$ dotnet new mstest -o Bcr.Fractions.Test`
`$ dotnet add Bcr.Fractions.Test/Bcr.Fractions.Test.csproj reference Bcr.Fractions/Bcr.Fractions.csproj`
`$ dotnet new console -o Bcr.Fractions.CommandLine`
`$ dotnet add Bcr.Fractions.CommandLine/Bcr.Fractions.CommandLine.csproj reference Bcr.Fractions/Bcr.Fractions.csproj`

## Run the console app

`dotnet run --project Bcr.Fractions.CommandLine`

## Run the unit tests

`dotnet test Bcr.Fractions.Test`
