using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Interfaces
{
    public interface IDirectoryReader
    {
        public List<FileInfo> GetFiles();
        public List<FileInfo> GetFilesWithFilter(Func<FileInfo , bool> e);
    }
}
