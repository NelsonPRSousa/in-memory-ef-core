# In Memory Entity Framework Core

Using Entity Framework Core's In Memory Provider to store a "database" in memory.

_Disclamer: This "database" is volatile. It's only as good as the memory it runs it.  Do not ever use the InMemory database provider for production application datastores._

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

```
Visual Studio 2017+ / Code
```

### Installing

Just compile and run. The below endpoints are available:
```
GET api/pointOfInterest
GET api/pointOfInterest/1
```

## Built With

* [ASP.NET Core 2.2](https://dotnet.microsoft.com/)
* [Entity Framework Core 2.2](https://github.com/aspnet/EntityFrameworkCore)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
