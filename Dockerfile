# 1-Runtime
# define an image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
MAINTAINER Gabriel Goncalves da Silva <gabrielgsdevbr@gmail.com>
# 2-Build
# define an image to build source code
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["FinanceManager.Domain/FinanceManager.Domain.csproj", "FinanceManager.Domain/"]
COPY ["FinanceManager.ApiClient/FinanceManager.ApiClient.csproj", "FinanceManager.ApiClient/"]
COPY ["FinanceManger.Infrastructure/FinanceManager.Infrastructure.csproj", "FinanceManger.Infrastructure/"]
COPY ["FinanceManager.Application/FinanceManager.Application.csproj", "FinanceManager.Application/"]
COPY ["FinanceManager.WebApi/FinanceManager.WebApi.csproj", "FinanceManager.WebApi/"]

RUN dotnet restore "FinanceManager.WebApi/FinanceManager.WebApi.csproj"
# copy from host folder system to container workdir folder
COPY . .

RUN dotnet build "FinanceManager.WebApi/FinanceManager.WebApi.csproj" -c Release -o /app/build

# 3-Publish the application
# publish the application to a folder in the container
FROM build AS publish
RUN dotnet publish "FinanceManager.WebApi/FinanceManager.WebApi.csproj" -c Release -o /app/publish

# 4-Final
# From base image and copying content from publish stage
# Runs the container with the application
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinanceManager.WebApi.dll"]

