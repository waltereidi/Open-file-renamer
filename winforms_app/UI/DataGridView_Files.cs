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
        }
        public void AddNewRowList(List<FileInfo> files)
        {
            this.Rows.Clear();
            AppendRows(files);
        }
        public void AppendRows(List<FileInfo> files)
            => files.ForEach(f => this.Rows.Add(GetRow(f)));
        private DataGridViewRow GetRow(FileInfo file)
        {
            DataGridViewRow row = (DataGridViewRow)this.Rows[0].Clone();
            row.Cells[0].Value = file.Name;
            row.Cells[1].Value = file.Length;
            
            var id = FileIdentity.Instance(file);
            row.Cells[2].Value = id.Id.ToString();
            return row;
        }
        
        

        public void SelectRow()
        {

        }

        public void GetSelectedRow()
        {

        }
    }
}
