using FileManager.DAO;
using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations.NumberedSequence
{
    public class NumberSequenceBeforeExtension : FileProcessor
    {
        private readonly int Sequence;
        private readonly string? Separator;
        public NumberSequenceBeforeExtension(DirectoryInfo path, FileIdentity fi, int sequence, string? separator = null) : base(path, fi)
        {
            Sequence = sequence;
            Separator = separator;
        }



        public override string GetRenameTo()
        {
            string nameWithouthExtension = FileNameBefore
                .Substring(0, FileNameBefore.LastIndexOf('.'));

            return string.Concat
                (
                    Sequence,
                    Separator,
                    nameWithouthExtension,
                    FileExtensionBefore
                );
        }
    }
}
