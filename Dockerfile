FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY DotnetCoreApiProj/*.csproj ./
RUN dotnet restore

# copy everything else and publish app
COPY DotnetCoreApiProj/* ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim-arm32v7 AS runtime
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "DotnetCoreApiProj.dll"]