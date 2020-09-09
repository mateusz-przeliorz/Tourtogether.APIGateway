using Tourtogether.APIGateway.GraphQL.Core;
using Tourtogether.APIGateway.GraphQL.InputTypes.Identity;

namespace Tourtogether.APIGateway.GraphQL.Resolvers.Mutations
{
    public class MutationResolver
    {
        public User CreateUser(CreateUserInput inputCreateUser) => new User
        {
            Email = inputCreateUser.Email,
            Name = inputCreateUser.Name,
            IsCreated = true
        };
    }
}
