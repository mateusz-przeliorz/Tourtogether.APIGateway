using HotChocolate.Types;

namespace Tourtogether.APIGateway.GraphQL.Mutations
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(t => t.CreateUser()).Type<NonNullType<StringType>>();
        }
    }
}
