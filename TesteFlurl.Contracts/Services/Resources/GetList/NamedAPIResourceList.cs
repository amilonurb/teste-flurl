using System.Collections.Generic;

namespace TesteFlurl.Contracts.Services.Resources.GetList
{
    public class NamedAPIResourceList
    {
        public IEnumerable<NamedAPIResource> Results { get; set; }
    }
}