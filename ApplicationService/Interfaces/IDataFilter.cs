
using ApplicationService.DAO;

namespace ApplicationService.Interfaces
{
    public interface IDataFilter
    {
        Func<string, bool> GetPerdicate();
        DataFilterOption GetFilterOption();
    }
}
