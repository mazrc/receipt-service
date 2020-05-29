# .NET Example Microservice Core Logic

## Techstack
- .NET Core
- C#
- Json.NET for deserializing input data
- Visual Studio Code

## Input
- Cart object / Array of Cart Objects
    - 


## Output
- Receipt Object
- Receipt Gets Printed on Console

## Ext Points
- Docker image
- Intercommunication of services

## Tests
Example JSON:
```
dotnet run "{\"createdDate\":\"2020-01-20T00:00:00Z\",\"items\":[{\"type\":1,\"id\":\"1\",\"name\":\"Chair\",\"price\":\"500.0\",\"quantity\":\"1\"}]}"
```
### Notes:
- packaging <Org>.<Service>
- using .NET naming conventions i.e., PascalCase