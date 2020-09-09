using HotChocolate.Types;
using Tourtogether.APIGateway.GraphQL.Types;

namespace Tourtogether.APIGateway.GraphQL.InputTypes.Identity
{
    public class CreateUserInput
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
