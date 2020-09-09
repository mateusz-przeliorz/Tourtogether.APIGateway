using System;
using Tourtogether.APIGateway.GraphQL.Core;
using Tourtogether.APIGateway.GraphQL.InputTypes.Identity;

namespace Tourtogether.APIGateway.GraphQL.Resolvers.Queries
{
    public class QueryResolver
    {
        public User FetchUser(GetUserInput inputGetUser) => new User
        {
            Email = inputGetUser.Email,
            Name = "Name has been taken from the service",
            IsCreated = true,
            CreatedAt = DateTime.Now
        };
    }
}
