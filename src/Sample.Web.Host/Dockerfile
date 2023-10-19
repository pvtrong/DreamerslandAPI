#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["../src/Sample.Web.Host/Sample.Web.Host.csproj", "src/Sample.Web.Host/"]
COPY ["../src/Sample.Web.Core/Sample.Web.Core.csproj", "src/Sample.Web.Core/"]
COPY ["../src/Sample.Application/Sample.Application.csproj", "src/Sample.Application/"]
COPY ["../src/Sample.Core/Sample.Core.csproj", "src/Sample.Core/"]
COPY ["../src/Sample.EntityFrameworkCore/Sample.EntityFrameworkCore.csproj", "src/Sample.EntityFrameworkCore/"]
RUN dotnet restore "src/Sample.Web.Host/Sample.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Sample.Web.Host"
RUN dotnet build "Sample.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sample.Web.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sample.Web.Host.dll"]