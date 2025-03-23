using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileManager.FileOperations.Pattern
{
    public class RegexPattern : FileProcessor
    {
        private readonly RegexPattern _regex;
        private readonly string? _text;
        public RegexPattern
        (
            DirectoryInfo path,
            FileIdentity fi,
            RegexPattern regex,
            string? text = null
        ) : base(path, fi)
        {
            _regex = regex;
            _text = text;
        }


        public override string GetRenameTo()
        {
            string nameWithouthExtension = FileNameBefore
                .Substring(0, FileNameBefore.LastIndexOf('.'));


            string modifiedName = Regex.Replace(nameWithouthExtension, _regex.ToString() , _text);
            return String.Concat(modifiedName , base.FileExtensionBefore);
        }
    }
}
