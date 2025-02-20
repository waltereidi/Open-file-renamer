using FileManager.DAO;
using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public class FilePreview
    {
        public string DisplayName { get; private set; } 
        public FileIdentity Id { get; private set; }
        public long Length { get; private set; }

        public FilePreview(FileInfo file)
        {
            DisplayName = file.Name;
            Id = FileIdentity.Instance(file);
            Length = file.Length;
        }
        public FilePreview(IFileProcessor file)
        {
            var fi = file.GetIdentity();
            
            DisplayName = file.GetRenameTo();
            Length = fi.GetFile().Length;
            Id = fi;
        }

    }
}
