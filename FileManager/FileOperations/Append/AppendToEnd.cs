using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations.Append
{
    public class AppendToEnd : FileProcessor
    {
        private readonly string? _text;
        public AppendToEnd
        (
            DirectoryInfo path,
            FileIdentity fi,
            string? text = null
        ) : base(path, fi)
        {
            _text = text;
        }



        public override string GetRenameTo()
        {
            string nameWithouthExtension = FileNameBefore
                .Substring(0, FileNameBefore.LastIndexOf('.'));

            return string.Concat
                (
                    nameWithouthExtension,
                    _text,
                    FileExtensionBefore
                );
        }
    }
}
