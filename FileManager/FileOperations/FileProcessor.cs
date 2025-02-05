using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public abstract class FileProcessor : IFileProcessor
    {
        protected readonly FileInfo _fileInfo;
        public abstract Task<Action> Start();
        public FileProcessor(FileInfo fi)
        {
            _fileInfo = fi;
            EnsureFileIsValid();
        }
        public abstract Task<Action> EnsureSuccessfullOperation();

        public virtual void EnsureFileIsValid()
        {
            if (!_fileInfo.Exists)
                throw new FileNotFoundException();
        }
    

    }
}
