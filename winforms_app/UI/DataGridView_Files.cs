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
            foreach (var f in files)
            {
                AppendRow(f, anotherGrid);
            }
        }
        private void AppendRow(FileInfo file, DataGridView_Files anotherGrid)
        {
            this.AllowUserToAddRows = true;
            var rowIdentities = GetTableRowIdentities(anotherGrid);
            EnsureFileCanBeAdded(rowIdentities, FileIdentity.Instance(file));
            var row = GetRow(file);
            this.Rows.Add(row);
            this.AllowUserToAddRows = false;
        }
           
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
        public bool EnsureFileCanBeAdded(List<string> rowIdentities, FileIdentity id)
            => !rowIdentities.Any( x => id.Equals(x) );

        public List<string> GetTableRowIdentities(DataGridView_Files source)
        {
            List<string> list = new(); 
            for (int i = 0; i < source.Rows.Count; i++)
            {
                var id = source.Rows[i].Cells[2].Value.ToString();
                list.Add(id);
            }
            return list;
        }

        public void AddSelectRowsFromThisToThere(DirectoryInfo dir , DataGridView_Files gridToAdd , List<int> list)
        {

        }
            

    }
}
