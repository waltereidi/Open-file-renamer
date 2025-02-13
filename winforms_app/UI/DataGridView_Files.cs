using FileManager.DAO;
using System.Collections.Generic;


namespace Presentation.UI
{
    public class DataGridView_Files : DataGridView
    {
        public DataGridView_Files() 
        {
            var column_FileName = new DataGridViewTextBoxColumn();
            var column_FileSize = new DataGridViewTextBoxColumn();
            var column_Hidden_FullName = new DataGridViewTextBoxColumn();
            this.Columns.AddRange(new DataGridViewColumn[] { column_FileName ,  column_FileSize, column_Hidden_FullName });
            // 
            // Column_Selection_FileName
            // 
            column_FileName.HeaderText = "Name";
            column_FileName.Name = "Column_FileName";
            column_FileName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // 
            // Column_Selection_FileSize
            // 
            column_FileSize.HeaderText = "Size";
            column_FileSize.Name = "Column_Selection_FileSize";
            column_FileName.AutoSizeMode  = DataGridViewAutoSizeColumnMode.Fill;
            // 
            // Column_Selection_Hidden_FullName
            // 
            column_Hidden_FullName.HeaderText = "hidden Id";
            column_Hidden_FullName.Name = "Column_Hidden_Id";
            column_Hidden_FullName.Visible = false;
            this.AllowUserToAddRows = false;
            
        }
        public void AddNewRowList(List<FileInfo> files , DataGridView_Files anotherGrid)
        {
            this.Rows.Clear();
            files.ForEach(f => AppendRow(f, anotherGrid)); 
        }
        private Task AppendRow(FileInfo file, DataGridView_Files anotherGrid)
           => EnsureFileCanBeAdded(anotherGrid, FileIdentity.Instance(file))
                .ContinueWith(_ => 
                {
                    if (!_.Result)
                        return;

                    this.AllowUserToAddRows = true;
                    this.Rows.Add(GetRow(file));
                    this.AllowUserToAddRows = false;
                });

        private DataGridViewRow GetRow(FileInfo file)
        {
            DataGridViewRow row = (DataGridViewRow)this.Rows[0].Clone();
            row.Cells[0].Value = file.Name;
            row.Cells[1].Value = file.Length;
            
            var id = FileIdentity.Instance(file);
            row.Cells[2].Value = id.Id.ToString();
            return row;
        }
        /// <summary>
        /// in case it is preview grid files could not have duplicated identity<br></br>
        /// </summary>
        /// <param name="anotherGrid"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task<bool> EnsureFileCanBeAdded(DataGridView_Files anotherGrid , FileIdentity id )
        {
            await foreach (var rowId in GetRowsAsync(anotherGrid) )
            {
                Thread.Sleep(20);
                var fileId = FileIdentity.Instance( rowId , id.Dir);
                if (fileId.Id == id.Id)
                    return false;
            }
            return true;
        }
        public async IAsyncEnumerable<string> GetRowsAsync(DataGridView_Files collection)
        {
            for (int i = 0; i < collection.Rows.Count; i++)
            {
                Thread.Sleep(20);
                await Task.Delay(i);
                yield return collection.Rows[i].Cells[2].Value.ToString();
            }
        }
        private async Task<FileIdentity> RemoveRow(DirectoryInfo dir , int rowIndex )
        {
            string id = this.Rows[rowIndex].Cells[2].Value.ToString();
            
            this.Rows.RemoveAt(rowIndex);

            return FileIdentity.Instance( id.ToString() , dir);
        }

        public async Task AddSelectRowsFromThisToThere(DirectoryInfo dir , DataGridView_Files gridToAdd , List<int> list)
            => list.ForEach(f => RemoveRow(dir, f)
                .ContinueWith(_ => AppendRow(_.Result.GetFile(), gridToAdd)));

    }
}
