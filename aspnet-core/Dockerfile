FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app


COPY /src/markaz.Web.Host/markaz.Web.Host.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish markaz.sln -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "markaz.Web.Host.dll"]