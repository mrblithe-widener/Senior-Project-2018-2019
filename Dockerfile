#Based on https://docs.docker.com/engine/examples/dotnetcore/

FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /usr/SPW/
COPY bin/Release/netcoreapp2.2/publish/ .
CMD ["dotnet", "SeniorProjectWebsite.dll"]