#!/bin/bash
export ASPNETCORE_ENVIRONMENT=local
cd src/Tourtogether.APIGateway
dotnet watch run --no-restore