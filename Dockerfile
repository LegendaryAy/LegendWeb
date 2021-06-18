FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
COPY . ./

RUN dotnet restore
COPY . ./

#Publishing
WORKDIR /app
RUN dotnet publish -c Release -o publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app

COPY --from=build /app/LegendWeb2.0/Legend.db .
COPY --from=build /app/publish .
#ENTRYPOINT ["dotnet", "LegendWeb2.0.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet LegendWeb2.0.dll
