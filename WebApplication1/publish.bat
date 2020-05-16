dotnet publish --runtime alpine-x64 -c Release --self-contained true -o ./publish /p:PublishSingleFile=true /p:PublishTrimmed=true


docker build --tag webapp1 -f Dockerfile .


docker run --rm  -p 12180:80 -p 13000:443  webapp1:latest