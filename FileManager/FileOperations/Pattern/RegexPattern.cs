using FileManager.DAO;
using System.Text.RegularExpressions;

namespace FileManager.FileOperations.Pattern
{
    public class RegexPattern : FileProcessor
    {
        private readonly string _regex;
        private readonly string? _text;
        public RegexPattern
        (
            DirectoryInfo path,
            FileIdentity fi,
            string regex,
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
