using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public class FileWriter : IDisposable
    {
        private IFileProcessor _file;
        public FileWriter(IFileProcessor file)
        {
            _file = file;
        }

        public async Task Start()
        {
            await _file.Start();
            await _file.EnsureSuccessfullOperation();
        }

        public void Dispose()
        {

        }
    }
}
