using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations.Pattern
{
    public class ToUpperPattern : FileProcessor
    {
        private readonly int _position;
        private readonly string? _text;
        public ToUpperPattern
        (
            DirectoryInfo path,
            FileIdentity fi
        ) : base(path, fi)
        {

        }

        public override string GetRenameTo()
        {
            string nameWithouthExtension = FileNameBefore
                .Substring(0, FileNameBefore.LastIndexOf('.'));


            return String.Concat(nameWithouthExtension.ToUpper(), FileExtensionBefore);
        }
    }
}
