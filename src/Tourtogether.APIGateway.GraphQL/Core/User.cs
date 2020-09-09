using System;

namespace Tourtogether.APIGateway.GraphQL.Core
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsCreated { get; set; }
    }
}
