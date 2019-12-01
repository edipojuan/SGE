FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app

# Copiar csproj e restaurar dependencias
COPY src/SGE.UI.Web/*.csproj ./
RUN dotnet restore

# Build da aplicacao
COPY . ./
RUN dotnet publish ./src/SGE.UI.Web/SGE.UI.Web.csproj -c Release -o out

# Build da imagem
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/src/SGE.UI.Web/out .
ENTRYPOINT ["dotnet", "SGE.UI.Web.dll"]