using HotChocolate.Types;
using Tourtogether.APIGateway.GraphQL.InputTypes.Identity;
using Tourtogether.APIGateway.GraphQL.Resolvers.Mutations;

namespace Tourtogether.APIGateway.GraphQL.Mutations
{
    public class MutationType : ObjectType
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Field<MutationResolver>(t => t.CreateUser(new CreateUserInput()));
        }
    }
}
