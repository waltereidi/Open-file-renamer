using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public class FileRenamer : FileProcessor
    {
        public string? _renameTo { get; private set; }
        public FileRenamer(string path) : base(new FileInfo(path))
        {

        }

        
        public void NumberSequenceBeforeExtension(int sequence , string? separator = null )
        {
            string nameWithouthExtension = _fileInfo.Name
                .Substring(0, _fileInfo.Name.LastIndexOf('.'));

            _renameTo = String.Concat
                (
                    nameWithouthExtension,
                    separator ,
                    sequence , 
                    _fileInfo.Extension 
                );
            
        }


        public override async Task<Action> Start()
            => !String.IsNullOrEmpty(_renameTo) 
            ? () => _fileInfo.MoveTo(_renameTo)
            : throw new ArgumentNullException("File name was not provided");

        public override async Task<Action> EnsureSuccessfullOperation()
        {
            return () => { };
        }
    }
}
