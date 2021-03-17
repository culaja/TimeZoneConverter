FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
RUN apt-get install tzdata -y

WORKDIR /TZConvertTestApp

COPY . ./
WORKDIR /TZConvertTestApp/TestApp
RUN dotnet run





