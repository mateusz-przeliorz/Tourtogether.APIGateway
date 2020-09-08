using HotChocolate.Types;

namespace Tourtogether.APIGateway.GraphQL.Queries
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
        }
    }
}
