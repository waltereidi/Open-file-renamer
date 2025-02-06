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
        public List<FileInfo> GetFilesContains(string text);
        public List<FileInfo> GetFilesGreaterThan(long size);
        public List<FileInfo> GetFilesSmallerThan(long size);
        public List<FileInfo> GetFilesSelect(List<FileInfo> files);
    }
}
