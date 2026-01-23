# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["SchoolManagementWeb.csproj", "./"]
RUN dotnet restore "SchoolManagementWeb.csproj"

COPY . .
RUN dotnet build "SchoolManagementWeb.csproj" -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
RUN dotnet publish "SchoolManagementWeb.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Create non-root user
RUN groupadd -r appuser && useradd -r -g appuser appuser

COPY --from=publish /app/publish .
RUN chown -R appuser:appuser /app
USER appuser

# Azure Web App expects port 80
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Production

ENTRYPOINT ["dotnet", "SchoolManagementWeb.dll"]