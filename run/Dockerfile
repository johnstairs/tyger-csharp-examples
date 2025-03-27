FROM mcr.microsoft.com/dotnet/sdk:9.0.102-azurelinux3.0 AS build

WORKDIR /app

COPY run.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:9.0.1-azurelinux3.0-distroless AS run
WORKDIR /app
COPY --from=build /out .
USER app:app
ENTRYPOINT ["/app/run"]