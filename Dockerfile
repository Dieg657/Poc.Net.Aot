# Defines an image for BUILD enviroment
FROM mcr.microsoft.com/dotnet/sdk:8.0-preview-alpine AS BUILD

# Install required libs
RUN apk add clang build-base zlib-dev

# Defines the work directory
WORKDIR /build

# Copy Everything
COPY . .

# Restore and Build application
RUN dotnet restore
RUN dotnet publish Poc.Net.Aot.Api -r linux-musl-x64 -c Release -o /app

# Defines an image for RUNTIME enviroment
FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview-alpine AS RUNTIME

# Add needed packages
RUN apk add --no-cache icu-libs

# Defines the work directory
WORKDIR /app

# Defines globalization invariant to FALSE
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Defines ASP .NET Core App Port
ENV ASPNETCORE_URLS=http://*:8080

COPY --from=BUILD /app .

ENTRYPOINT ["./Poc.Net.Aot.Api"]