# 1-Sets image
# define a imagem base
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /FinanceManagerApi
EXPOSE 80
EXPOSE 443

# 2-Copy project files and restore dependencies
# 3-Build app
# definir informações que a imagem precisa
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /FinanceManagerApi
COPY["FinanceManager.Domain/FinanceManager.Domain.csproj", "FinanceManager.Domain/"]
COPY["FinanceManager.ApiClient/FinanceManager.ApiClient.csproj", "FinanceManager.ApiClient/"]
COPY["FinanceManger.Infrastructure/FinanceManger.Infrastructure.csproj", "FinanceManger.Infrastructure/"]
COPY["FinanceManager.WebApi/FinanceManager.WebApi.csproj", "FinanceManager.WebApi/"]
COPY["FinanceManager.Application/FinanceManager.Application.csproj", "FinanceManager.Application/"]
RUN dotnet restore "FinanceManager.Domain/FinanceManager.Domain.csproj"
RUN dotnet restore "FinanceManager.ApiClient/FinanceManager.ApiClient.csproj"
RUN dotnet restore "FinanceManger.Infrastructure/FinanceManger.Infrastructure.csproj"
RUN dotnet restore "FinanceManager.WebApi/FinanceManager.WebApi.csproj"
COPY . .
WORKDIR "/FinanceManager.WebApi"
RUN dotnet build "FinanceManager.WebApi.csproj" -c Release -o /FinanceManagerApi/build


# 4-Publish the application
# publicação da aplicação
FROM build AS publish
RUN dotnet publish "FinanceManager.WebApi.csproj" -c Release -o /FinanceManagerApi/publish

# From base image copies and publish
# apartir da imagem base copia o que foi feito em publish 
FROM base AS final
WORKDIR /FinanceManagerApi
COPY --from=publish /FinanceManagerApi/publish .
EntryPoint ["dotnet", "FinanceManager.WebApi.dll"]

