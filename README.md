# Redis_Basic
A basic application using Redis caching and docker

# Redis container pull in docker: 
docker pull redis
docker run -d -p 6379:6379 --name local-redis redis

# going inside redis
docker exec -it local-redis /bin/bash

docker exec -it testdb /bin/bash

redis-cli

# Nuget Package for Redis
Microsoft.Extensions.Caching.StackExchangeRedis


#Container compose
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
