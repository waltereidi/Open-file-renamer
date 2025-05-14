using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations.Pattern
{
    public class ReplacePattern : FileProcessor
    {
        private readonly string _pattern;
        private readonly string? _text;
        public ReplacePattern
        (
            DirectoryInfo path,
            FileIdentity fi,
            string pattern,
            string? text = null
        ) : base(path, fi)
        {
            _pattern= pattern;
            _text = text?? "";
        }



        public override string GetRenameTo()
        {
            if (String.IsNullOrEmpty(_pattern) )
                return FileNameBefore;

            string nameWithouthExtension = FileNameBefore
                .Substring(0, FileNameBefore.LastIndexOf('.'));

            nameWithouthExtension = nameWithouthExtension.Replace( _pattern , _text);

            return String.Concat(nameWithouthExtension , base.FileExtensionBefore);
        }
    }
}
