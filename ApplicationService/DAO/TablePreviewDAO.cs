using ApplicationService.DTO;
using ApplicationService.Interfaces;
using FileManager.DAO;

namespace ApplicationService.DAO
{
    public class TablePreviewDAO : DataHandler , ITablePreview
    {
        public class TableRows
        {
            public string FileName { get; set; }
            public FileIdentity FileIdentity { get; set; }
        }
        private readonly MainApplicationService _service;
        private IOperationContract OperationContract { get; set; }
        private List<TablePreviewDAO.TableRows> Rows { get;set; }
        public List<TablePreviewDAO.TableRows> GetRows()
            => Rows;
        public TablePreviewDAO(DirectoryInfo dir, IOperationContract oc)
            :base(dir)
        {
            _service = new MainApplicationService();

            Rows = new();
            OperationContract = oc;
            GetPreview();
        }

        public void SetDataPreview(IOperationContract oc)
        {
            OperationContract = oc;
            GetPreview();
        }
  
        private void GetPreview()
        {
            if (OperationContract == null)
                return;

            var files = _service.GetPreview(OperationContract);   
            //var rows = Dir.GetFiles()
            //    .Select(s => new TablePreviewDAO.TableRows()
            //    {
            //        FileIdentity = FileIdentity.Instance(s.FullName, Dir),
            //        FileName = s.Name,
            //        FileSize = s.Length,
            //        IsChecked = true
            //    }).ToList();

            //Rows = ReCheckFiles(rows); 
        }

    }

}
