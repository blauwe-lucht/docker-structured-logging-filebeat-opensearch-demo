FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY SerilogLogGenerator/SerilogLogGenerator.csproj ./SerilogLogGenerator/

RUN dotnet restore ./SerilogLogGenerator/SerilogLogGenerator.csproj

COPY ./SerilogLogGenerator ./SerilogLogGenerator/

WORKDIR /src/SerilogLogGenerator
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "SerilogLogGenerator.dll"]
