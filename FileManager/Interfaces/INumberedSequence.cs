using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Interfaces
{
    public interface INumberedSequence 
    {
        public List<IFileProcessor> GetNumberedSequenceAfterPreview(List<FileIdentity> files, string separator);
        public List<IFileProcessor> GetNumberedSequenceBeforePreview(List<FileIdentity> files, string separator);
        public void GetNumberedSequenceBefore(List<FileIdentity> files, string separator);
        public void GetNumberedSequenceAfter(List<FileIdentity> files, string separator);
    }
}
