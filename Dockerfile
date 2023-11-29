# slika, ki jo uporabimo za osnovo/strežnik

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

# delovni direktorij v sliki

WORKDIR /app

 

# vrata, ki jih želimo odpreti

EXPOSE 80

EXPOSE 443

 

# slika, ki jo uporabimo za izgradnjo

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src

# kopiranje datotek v delovni direktorij

COPY ["LigaCup/LigaCup.csproj", "LigaCup/"]

# zagon ukaza za obnovo vseh odvisnosti

RUN dotnet restore "LigaCup/LigaCup.csproj"

COPY . .

WORKDIR "/src/LigaCup"

# zagon ukaza za izgradnjo projekta

RUN dotnet build "LigaCup.csproj" -c Release -o /app/build

 

FROM build AS publish

RUN dotnet publish "LigaCup.csproj" -c Release -o /app/publish /p:UseAppHost=false

# zagon ukaza za objavo projekta

 

FROM base AS final

WORKDIR /app

# kopiranje datotek iz začasne slike v končno

COPY --from=publish /app/publish .

# zagon ukaza za zagon aplikacije

ENTRYPOINT ["dotnet", "LigaCup.dll"]