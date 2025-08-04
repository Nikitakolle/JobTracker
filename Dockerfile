# Use .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything to /src
COPY . .

# Restore dependencies and publish app
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# Use ASP.NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published app from build stage
COPY --from=build /app/publish ./

# Expose port 80
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "JobTracker.dll"]
