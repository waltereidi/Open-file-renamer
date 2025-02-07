using FileManager.DAO;
using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public abstract class FileProcessor : IFileProcessor
    {

        public readonly FileIdentity Id;
        public readonly DirectoryInfo Dir;
        public FileProcessor(DirectoryInfo dr, FileInfo fi)
        {
            Dir = dr; 
            Id = FileIdentity.Instance(fi);
            EnsureFileIsValid();
        }
        protected FileInfo GetFile() => Dir.GetFiles().First(x => Id.Equals(x));

        public void Start()
        {
            var file = this.GetFile();
            Operation(file);
            EnsureSuccessfullOperation();
        }

        protected abstract void Operation(FileInfo fi);
        public abstract void EnsureSuccessfullOperation();
        public virtual void EnsureFileIsValid()
        {
            if (!this.GetFile().Exists)
                throw new FileNotFoundException();
        }

        

    }
}
