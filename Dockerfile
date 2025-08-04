# Use .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything first (not just .csproj)
COPY . .

# Change to your project directory
WORKDIR /src/JobTracker

# Restore and publish
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# Use ASP.NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish ./

EXPOSE 80

ENTRYPOINT ["dotnet", "JobTracker.dll"]
