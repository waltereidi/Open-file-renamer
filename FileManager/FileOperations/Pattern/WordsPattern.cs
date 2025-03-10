using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations.Pattern
{
    public class WordsPattern : FileProcessor
    {
        private readonly int _position;
        private readonly string? _text;
        public WordsPattern
        (
            DirectoryInfo path,
            FileIdentity fi,
            int position,
            string? text = null
        ) : base(path, fi)
        {
            _position = position;
            _text = text;
        }
        public override string GetRenameTo()
        {
            string nameWithouthExtension = FileNameBefore
                .Substring(0, FileNameBefore.LastIndexOf('.'));


            return null;
        }
    }
}
