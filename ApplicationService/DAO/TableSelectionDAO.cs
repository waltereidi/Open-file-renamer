using ApplicationService.DTO;
using ApplicationService.Interfaces;
using FileManager.DAO;

namespace ApplicationService.DAO
{
    public class TableSelectionDAO : DataHandler , ITableSelection
    {
        public class TableRows
        {
            public string FileName { get; set; }
            public long FileSize { get; set; }
            public FileIdentity FileIdentity { get; set; }
            public bool IsChecked { get; set; } = true;
        }
        private IDataFilter DataFilter { get; set; }
        private List<TableSelectionDAO.TableRows> Rows { get;set; }
        public List<TableSelectionDAO.TableRows> GetRows()
            => Rows;
        public IEnumerable<TableSelectionDAO.TableRows> GetCheckedRows()
            => Rows.Where(x => x.IsChecked);
        public TableSelectionDAO(DirectoryInfo dir, IDataFilter filter)
            :base(dir)
        {
            Rows = new();
            DataFilter = filter;
            GetTableFiles();
        }

        public void SetDataFilter(IDataFilter d)
        {
            DataFilter = d;
            GetTableFiles();
        }
        public void CheckBoxChanged(FileIdentity fi , bool value)
            => Rows.ForEach(x => {
                if (x.FileIdentity.Equals(fi.Id))
                    x.IsChecked = value;
            });
        private List<TableSelectionDAO.TableRows> ReCheckFiles(List<TableSelectionDAO.TableRows> rows)
        {
            List<FileIdentity> checkedFiles = this.Rows.Where(x => x.IsChecked)
                    .Select(s => s.FileIdentity).ToList();
                
            rows.ForEach(f => f.IsChecked = checkedFiles.Any(x => x.Id.Equals(f.FileIdentity.Id) == false)
                ? false
                : true );

            return rows;
        }
        private void GetTableFiles()
        {
            var rows = Dir.GetFiles()
                .Where(x => Predicate(x))
                .Select(s => new TableSelectionDAO.TableRows()
                {
                    FileIdentity = FileIdentity.Instance(s.FullName, Dir),
                    FileName = s.Name,
                    FileSize = s.Length,
                    IsChecked = true
                }).ToList();

            Rows = ReCheckFiles(rows); 
        }

        private bool Predicate(FileInfo dto)
        {
            if (DataFilter == null )
                return true;
            else
            {
                switch (DataFilter.GetFilterOption())
                {
                    case DataFilterOption.Contains:
                        return DataFilter.GetPerdicate().Invoke(dto.Name);
                    case DataFilterOption.BiggerThan:
                        return DataFilter.GetPerdicate().Invoke(dto.Length.ToString());
                    case DataFilterOption.SmallerThan:
                        return DataFilter.GetPerdicate().Invoke(dto.Length.ToString());
                    case DataFilterOption.Extension:
                        return DataFilter.GetPerdicate().Invoke(dto.Extension);
                    default:
                        return DataFilter.GetPerdicate().Invoke(dto.Name);
                }
            }
        }

    }

}
