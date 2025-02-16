using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Interfaces
{
    public interface IFileManager : IDirectoryReader
    {
        public Task NumberSequenceBeforeExtension(List<FileInfo> files , string separator);
        public List<FileInfo> GetFiles();
    }
}
