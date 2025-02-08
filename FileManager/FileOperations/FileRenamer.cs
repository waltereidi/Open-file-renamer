using FileManager.Interfaces;
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
        private FileRenamer(DirectoryInfo path , FileInfo fi) : base(path , fi) { }

        
        public static IFileProcessor NumberSequenceBeforeExtension(DirectoryInfo path, FileInfo fi , int sequence , string? separator = null )
        {
            var fr = new FileRenamer(path , fi);
            
            var file = fr.GetFile();
            string nameWithouthExtension = file.Name
                .Substring(0, file.Name.LastIndexOf('.'));

            fr._renameTo = String.Concat
                (
                    nameWithouthExtension,
                    separator ,
                    sequence , 
                    file.Extension 
                );
            return fr;
        }


        protected override void Operation(FileInfo fi) 
            => fi.MoveTo(Path.Combine(Dir.FullName, _renameTo 
               ?? throw new ArgumentNullException(nameof(_renameTo))));


        public override void EnsureSuccessfullOperation()
        {
            throw new NotImplementedException();
        }
    }
}
