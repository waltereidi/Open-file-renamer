using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DAO
{
    public class VersionedModifications
    {
        public record Version(Guid id, List<IFileProcessor> files , int order);
        private Version _Version { get; set; }
        public List<IFileProcessor> GetVersion() => _Version.files;
        public void AddVersion(List<IFileProcessor> files)
            => _Version = new Version(Guid.NewGuid(), files, 0);

    } 
}
