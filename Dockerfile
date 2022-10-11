FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
WORKDIR "/src"
RUN ls
ENTRYPOINT ["dotnet", "test"]