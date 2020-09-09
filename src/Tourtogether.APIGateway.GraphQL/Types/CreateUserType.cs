using HotChocolate.Types;
using Tourtogether.APIGateway.GraphQL.Core;

namespace Tourtogether.APIGateway.GraphQL.Types
{
    public class CreateUserType : ObjectType<User>
    {
        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Field(b => b.Email).Type<NonNullType<StringType>>();
            descriptor.Field(b => b.Name).Type<NonNullType<StringType>>();
            descriptor.Field(b => b.IsCreated).Type<NonNullType<BooleanType>>();
            descriptor.Field(t => t.CreatedAt).Type<NonNullType<DateType>>();
        }
    }
}
