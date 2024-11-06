# Consulte https://aka.ms/customizecontainer para aprender a personalizar su contenedor de depuración y cómo Visual Studio usa este Dockerfile para compilar sus imágenes para una depuración más rápida.

# Esta fase se usa cuando se ejecuta desde VS en modo rápido (valor predeterminado para la configuración de depuración)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# Esta fase se usa para compilar el proyecto de servicio
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AUPExpert.Service.WebUI/AUPExpert.Service.WebUI.csproj", "AUPExpert.Service.WebUI/"]
COPY ["AUPExpert.Application.DTO/AUPExpert.Application.DTO.csproj", "AUPExpert.Application.DTO/"]
COPY ["AUPExpert.Application.Interface/AUPExpert.Application.Interface.csproj", "AUPExpert.Application.Interface/"]
COPY ["AUPExpert.Common/AUPExpert.Common.csproj", "AUPExpert.Common/"]
COPY ["AUPExpert.Domain/AUPExpert.Domain.csproj", "AUPExpert.Domain/"]
COPY ["AUPExpert.Application.UseCases/AUPExpert.Application.UseCases.csproj", "AUPExpert.Application.UseCases/"]
COPY ["AUPExpert.Application.Validator/AUPExpert.Application.Validator.csproj", "AUPExpert.Application.Validator/"]
COPY ["AUPExpert.Persistence/AUPExpert.Persistence.csproj", "AUPExpert.Persistence/"]
RUN dotnet restore "./AUPExpert.Service.WebUI/AUPExpert.Service.WebUI.csproj"
COPY . .
WORKDIR "/src/AUPExpert.Service.WebUI"
RUN dotnet build "./AUPExpert.Service.WebUI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Esta fase se usa para publicar el proyecto de servicio que se copiará en la fase final.
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AUPExpert.Service.WebUI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Esta fase se usa en producción o cuando se ejecuta desde VS en modo normal (valor predeterminado cuando no se usa la configuración de depuración)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AUPExpert.Service.WebUI.dll"]