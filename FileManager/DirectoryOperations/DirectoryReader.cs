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
            => _dir = dir.Exists 
                ? dir 
                : throw new DirectoryNotFoundException(dir.FullName);

        public List<FileInfo> GetFiles() 
            => _dir.GetFiles().ToList();
        public List<FileInfo> GetFilesContains(string text)
            => _dir.GetFiles().Where(f => f.Name.Contains(text)).ToList();

        public List<FileInfo> GetFilesGreaterThan(long? size)
            => _dir.GetFiles().Where(f => size == null || f.Length > size).ToList();

        public List<FileInfo> GetFilesSmallerThan(long? size)
            => _dir.GetFiles().Where(f => size == null || f.Length < size).ToList();
        
    }
}
