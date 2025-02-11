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
            this.AllowUserToAddRows = true;
            this.Rows.Clear();
            AppendRows(files , anotherGrid);
            this.AllowUserToAddRows = false;
        }
        public void AppendRows(List<FileInfo> files, DataGridView_Files anotherGrid)
            => files.Where(x => EnsureFileCanBeAdded(anotherGrid, FileIdentity.Instance(x)))
            .ToList()
            .ForEach(f => this.Rows.Add(GetRow(f)));
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
        public bool EnsureFileCanBeAdded(DataGridView_Files anotherGrid , FileIdentity id )
        {
            foreach(DataGridViewRow  row in anotherGrid.Rows)
            {
                var fileId = FileIdentity.Instance(row.Cells[2].Value.ToString() , id.Dir);
                if (fileId.Id == id.Id)
                    return false;
            }
            return true;
        }
        

        public void AddSelectRowFromThisToThere(DataGridView_Files preview , List<FileInfo> list)
        {
        }

        public void GetSelectedRow()
        {

        }
    }
}
