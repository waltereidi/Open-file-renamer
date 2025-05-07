using ApplicationService.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interfaces
{
    public interface ITablePreview
    {
        public List<TablePreviewDAO.TableRows> GetRows();
        public void SetDataPreview(IOperationContract oc);
    }
}
