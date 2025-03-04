using FileManager.DAO;
using FileManager.FileOperations;
using FileManager.Interfaces;


namespace Presentation.UI
{
    public class DataGridView_Files : DataGridView
    {
        private DataGridViewRowCollection StoredRows { get; set; }

        public DataGridView_Files() 
        {
        }
        
        public void AddNewRowList(List<IFileProcessor> files, DataGridView_Files anotherGrid)
            => AddNewRowList(files.Select(s => new FilePreview(s)).ToList() , anotherGrid);
        public void AddNewRowList(List<FileInfo> files, DataGridView_Files anotherGrid)
            => AddNewRowList(files.Select(s => new FilePreview(s)).ToList(), anotherGrid);
        public void AddNewRowList(List<FilePreview> files, DataGridView_Files anotherGrid)
        {
            this.Rows.Clear();
            files.ForEach(f => AppendRow(f , anotherGrid) );
        }

        private void AppendRow(FilePreview file, DataGridView_Files anotherGrid)
        {
            this.AllowUserToAddRows = true;
            var rowIdentities = GetTableRowIdentities(anotherGrid);
            if(EnsureFileCanBeAdded(rowIdentities, file.Id))
            {
                var row = GetRow(file);
                this.Rows.Add(row);
            }
            this.AllowUserToAddRows = false;
        }
           
        private DataGridViewRow GetRow(FilePreview file)
        {
            DataGridViewRow row = (DataGridViewRow)this.Rows[0].Clone();
            row.ReadOnly = true;
            row.Cells[0].Value = file.DisplayName;
            
            row.Cells[1].Value = file.Length;

            row.Cells[2].Value = file.Id.GetId();

            return row;
        }
        /// <summary>
        /// in case it is preview grid files could not have duplicated identity<br></br>
        /// </summary>
        /// <param name="anotherGrid"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool EnsureFileCanBeAdded(List<string> rowIdentities, FileIdentity id)
            => !rowIdentities.Any( x => id.Equals(x) );

        public List<string> GetTableRowIdentities(DataGridView_Files source)
        {
            List<string> result = new(); 
            for (int i = 0; i < source.Rows.Count; i++)
            {
                var id = source.Rows[i].Cells[2].Value.ToString();
                result.Add(id);
            }
            return result;
        }
        public List<string> GetIdentityFromIndexes(List<int> indexes)
            => indexes.Select(s 
                => this.Rows[s].Cells[2].Value.ToString() ?? throw new ArgumentNullException() )
            .ToList();
        public void DirectoryChanged()
        {
            this.Rows.Clear();
            this.StoredRows.Clear();
        }
        public void AddSelectRowsFromThisToThere(DirectoryInfo di , 
            DataGridView_Files gridToAdd , 
            List<int> list
            )
        {
            var rowIdentities = GetIdentityFromIndexes(list); 

            var identities = FileIdentity.Instances(rowIdentities, di);
            
            list.ForEach(f => this.Rows.RemoveAt(f));

            identities.ForEach(f => gridToAdd.AppendRow(new FilePreview(f.GetFile()) , this ));

        }
        public void DeselectAnotherGrid(DataGridView_Files grid)
            => grid.ClearSelection();
        
        public List<int> GetSelectedRowsIndexes()
        {
            var result = new List<int>();
            for(int i = 0; i < this.SelectedRows.Count; i++ )
            {
                result.Add( this.SelectedRows[i].Index );
            }
            return result;
        }

        public void SaveCurrentGrid()
            => this.StoredRows = this.Rows;

        public void RestoreStoredRows()
        {
            this.Rows.Clear();
            if (StoredRows != null && StoredRows.Count > 0 )
            {
                
                foreach (var item in StoredRows)
                {
                    this.Rows.Add(item);
                }
                StoredRows.Clear();
            }
        }

        public List<FileIdentity> GetAllFiles(DirectoryInfo di)
        {
            DataGridViewRow[] rows = new DataGridViewRow[this.Rows.Count];
            this.Rows.CopyTo(rows , 0);

            return rows.ToList()
                .Select(s => FileIdentity.Instance(s.Cells[2].Value.ToString(),di) )
                .ToList();
        }
    }
}
