using HotChocolate.Types;
using Tourtogether.APIGateway.GraphQL.InputTypes.Identity;
using Tourtogether.APIGateway.GraphQL.Resolvers.Queries;

namespace Tourtogether.APIGateway.GraphQL.Queries
{
    public class QueryType : ObjectType
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Field<QueryResolver>(t => t.FetchUser(new GetUserInput()));
        }
    }
}
