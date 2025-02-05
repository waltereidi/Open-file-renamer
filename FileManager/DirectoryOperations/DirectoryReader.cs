using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DirectoryOperations
{
    public class DirectoryReader : IDirectoryReader
    {
        private readonly DirectoryInfo _dir;
        public DirectoryReader(DirectoryInfo dir)
        {
            _dir = dir;
        }

        public List<FileInfo> GetFiles() 
            => _dir.GetFiles().ToList();

        public List<FileInfo> GetFilesWithFilter(Func<FileInfo , bool> e) 
            => _dir.GetFiles().Where(e).ToList();
    }
}
