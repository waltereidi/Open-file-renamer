
using ApplicationService.DAO;
using FileManager.DAO;

namespace ApplicationService.Interfaces
{
    public interface ITableSelection
    {
        public void SetDataFilter(IDataFilter d);
        public void CheckBoxChanged(FileIdentity fi, bool value);
        public List<TableSelectionDAO.TableRows> GetRows();
        public IEnumerable<TableSelectionDAO.TableRows> GetCheckedRows();
    }
}
