namespace TesteFlurl.Contracts.Services.Resources.GetList
{
    public interface IGetResourcesListService
    {
        NamedAPIResourceList Execute(int limit);
    }
}
