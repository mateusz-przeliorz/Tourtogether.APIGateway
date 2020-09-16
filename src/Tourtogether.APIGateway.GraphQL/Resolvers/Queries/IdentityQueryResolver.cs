using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Tourtogether.APIGateway.GraphQL.Core;
using Tourtogether.APIGateway.GraphQL.InputTypes.Identity;

namespace Tourtogether.APIGateway.GraphQL.Resolvers.Queries
{
    public class IdentityQueryResolver
    {
        public HttpClient Client { get; }
        public IdentityQueryResolver()
        {
            Client = new HttpClient {BaseAddress = new Uri("https://localhost:6002/api/")};
        }

        public async Task<User> FetchUser(GetUserInput inputGetUser) => await GetUserAsync();

        private async Task<User> GetUserAsync()
        {
            var result = await Client.GetAsync("default").Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<User>(result);
        }
    }
}
