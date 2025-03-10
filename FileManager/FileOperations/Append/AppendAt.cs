using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations.Append
{
    public class AppendAt : FileProcessor
    {
        private readonly int _position;
        private readonly string? _text;
        public AppendAt
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

            int position = _position;
            if (position > nameWithouthExtension.Length - 1)
                position = nameWithouthExtension.Length;

            string result = nameWithouthExtension.Substring(0, position);

            result += _text;
            result += nameWithouthExtension.Substring(position);
            result += FileExtensionBefore;
            return result;
        }
    }
}
