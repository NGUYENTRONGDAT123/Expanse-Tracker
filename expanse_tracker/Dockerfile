FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["expanse_tracker.csproj", "./"]
RUN dotnet restore "./expanse_tracker.csproj"
COPY . .
RUN dotnet build "expanse_tracker.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "expanse_tracker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "expanse_tracker.dll"]