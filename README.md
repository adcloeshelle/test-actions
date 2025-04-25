# Basic C# Application

[![.NET](https://github.com/jloeshelle/test-actions/actions/workflows/dotnet.yml/badge.svg)](https://github.com/jloeshelle/test-actions/actions/workflows/dotnet.yml)
[![Code Coverage](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/jloeshelle/YOUR_GIST_ID_HERE/raw/coverage.json)](https://github.com/jloeshelle/test-actions/actions/workflows/dotnet.yml)

A simple C# application with a Calculator class and MSTest unit tests.

## Project Structure

- `src/BasicCSharpApp.Core`: Contains the core functionality
- `test/BasicCSharpApp.Tests`: Contains the unit tests

## Features

- Basic arithmetic operations (Add, Subtract, Multiply, Divide)
- 100% code coverage with unit tests
- GitHub Actions CI/CD pipeline
- Code coverage reporting

## Getting Started

### Prerequisites

- .NET 9.0 SDK

### Building the Project

```bash
dotnet build
```

### Running the Tests

```bash
dotnet test
```

### Running the Tests with Code Coverage

```bash
dotnet test --collect:"XPlat Code Coverage"
```