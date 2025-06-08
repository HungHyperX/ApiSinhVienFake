# Sử dụng image .NET SDK để build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj và restore
COPY *.csproj ./
RUN dotnet restore

# Copy toàn bộ source và build
COPY . ./
RUN dotnet publish -c Release -o out
RUN dotnet publish -c Release -o out

# Sử dụng runtime image để chạy app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port
EXPOSE 80
ENTRYPOINT ["dotnet", "ApiSinhVien.dll"]
