FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
COPY . .
RUN dotnet publish src/Tourtogether.APIGateway -c release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /app/out .
ENV ASPNETCORE_URLS http://*:6000
EXPOSE 6000
ENTRYPOINT ["dotnet", "Tourtogether.APIGateway.dll"]