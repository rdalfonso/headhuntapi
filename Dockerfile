FROM microsoft/aspnetcore-build:2.0 AS build-env
RUN mkdir /app
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore headhuntapi.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish headhuntapi.csproj -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "headhuntapi.dll"]
