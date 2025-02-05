using FileManager.FileOperations;
using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class FileManagerService : IFileManager
    {
        public FileManagerService()
        {

        }

        public async Task NumberSequenceBeforeExtension(List<FileInfo> files , string separator )
        {
            List<Task> tasks = new();

            foreach ( var f in files.Select((v , i) => (v , i )) )
            {
                IFileProcessor fr = new FileRenamer(f.v.FullName);

                FileWriter fw = new(fr);
                
                tasks.Add( fw.Start());
            }
            
            await Task.WhenAll(tasks);

        }


    }
}
