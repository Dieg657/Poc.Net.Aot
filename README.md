# Poc.Net.Aot
.NET Core Web API using AOT deployment

## Motivations

This application is made to learn how implements .NET Core Minimum WebAPI using .NET 8 Preview (Release 7) with AOT (Ahead of Time) deployment

# How to use?

You needs Docker with compose (docker-compose)
Once you had it, then run:
```
docker-compose build
```
To build Dockerfile and generates image of the WebAPI

At last, run:
```
docker-compose up
```
Finally you're able to use this Web API

# WARNING

If you'd compile the project, you need at this moment (7th of September): Visual Studio Community 2022 (Preview) and .NET 8 Preview (Release 7) minimum to open and compile the same.
