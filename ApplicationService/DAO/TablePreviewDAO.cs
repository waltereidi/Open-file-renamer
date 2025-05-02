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
        private IDataPreview DataPreview { get; set; }
        private List<TablePreviewDAO.TableRows> Rows { get;set; }
        public List<TablePreviewDAO.TableRows> GetRows()
            => Rows;
        public TablePreviewDAO(DirectoryInfo dir, IDataPreview preview)
            :base(dir)
        {
            Rows = new();
            DataPreview = preview;
            GetTableFiles();
        }

        public void SetDataPreview(IDataPreview d)
        {
            DataPreview = d;
            GetTableFiles();
        }
  
        private void GetTableFiles()
        {
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
