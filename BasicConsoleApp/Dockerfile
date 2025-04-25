#ref: https://github.com/dotnet/dotnet-docker/tree/main/samples/complexapp

# build copies all project files and restores NuGet packages
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG TARGETARCH
WORKDIR /source

# Copy project file and restore as distinct layers
COPY --link BasicConsoleApp/*.csproj BasicConsoleApp/
RUN dotnet restore -a $TARGETARCH BasicConsoleApp/BasicConsoleApp.csproj

# Copy source code and publish app
COPY --link BasicConsoleApp/ BasicConsoleApp/

# BasicConsoleApp.Tests builds the xUnit test project
FROM build AS test-build

COPY --link BasicConsoleApp.Tests/*.csproj BasicConsoleAppTests/
WORKDIR /source/BasicConsoleAppTests
RUN dotnet restore

COPY --link BasicConsoleApp.Tests/ .
RUN dotnet build --no-restore

# BasicConsoleAppTests exposes tests as the default executable for the stage
FROM test-build AS test
ENTRYPOINT ["dotnet", "test", "--no-build", "--logger:trx"]

# publish builds and publishes BasicConsoleApp
FROM build AS publish
WORKDIR /source/BasicConsoleApp
RUN dotnet publish -a $TARGETARCH --no-restore -o /app

# final is the final runtime stage for running the app
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS final
WORKDIR /app
COPY --link --from=publish /app .
ENTRYPOINT ["dotnet", "BasicConsoleApp.dll"]