using Flurl;
using Flurl.Http;
using TesteFlurl.Contracts.Services.Resources.GetList;

namespace TesteFlurl.Services.Resources.GetList
{
    public class GetResourcesListService : IGetResourcesListService
    {
        public NamedAPIResourceList Execute(int limit)
        {
            var url = "https://pokeapi.co/api/v2/pokemon";

            return url.SetQueryParams(new { limit })
                      .GetJsonAsync<NamedAPIResourceList>()
                      .GetAwaiter()
                      .GetResult();
        }
    }
}
