#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0-preview AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build
WORKDIR /src
COPY . .
RUN dotnet restore "LeetCode.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "LeetCode.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetCode.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeetCode.dll"]
