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
        private List<IFileProcessor> _file;
        public FileWriter(List<IFileProcessor> file)
        {
            _file = file;
            
        }

        public async Task Start() =>Task.WaitAll( _file.Select(s => Task.Run(() => s.Start()) ).ToArray() );


        public void Dispose()
        {

        }
    }
}
