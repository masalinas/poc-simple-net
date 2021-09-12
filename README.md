# Description
A simple API ASP NET Core PoC

# Create project
dotnet new webapi -o poc-net-simple --no-https

# Compile
dotnet publish -c Release

# Execute
dotnet run

# Compile image
docker build -t poc-simple-net .

# run image
docker run -it --rm --name poc-simple-net -p 5000:80 poc-simple-net

# Access swagger UI
http://localhost:5000/swagger/index.html

# Test api
curl -X GET http://localhost:5000/greeting/World
