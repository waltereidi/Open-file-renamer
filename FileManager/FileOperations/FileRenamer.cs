using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public class NumberSequenceBeforeExtension : FileProcessor
    {
        private readonly int Sequence;
        private readonly string? Separator;
        public NumberSequenceBeforeExtension(DirectoryInfo path, FileInfo fi, int sequence, string? separator = null) : base(path , fi) 
        {
            Sequence = sequence;
            Separator = separator;
        }

        protected override void EnsureSuccessfullOperation()
        {
            throw new NotImplementedException();
        }

        public override string GetRenameTo()
        {
            var file = base.GetFile();
            string nameWithouthExtension = file.Name
                .Substring(0, file.Name.LastIndexOf('.'));

            return String.Concat
                (
                    nameWithouthExtension,
                    Separator,
                    Sequence,
                    file.Extension
                );
        }
    }
}
