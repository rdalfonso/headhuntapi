FROM microsoft/aspnetcore-build:2.0 AS build-env
RUN mkdir /app
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore headhuntapi.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish headhuntapi.csproj -o /publish

WORKDIR /publish

ENTRYPOINT ["dotnet", "/publish/headhuntapi.dll"]