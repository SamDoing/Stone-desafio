#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Stone Desafio/Stone Desafio.csproj", "Stone Desafio/"]
RUN dotnet restore "Stone Desafio/Stone Desafio.csproj"
COPY . .
WORKDIR "/src/Stone Desafio"
RUN dotnet build "Stone Desafio.csproj" -c Release -o /app/build

FROM build AS Test
ENTRYPOINT ["dotnet", "test"]