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
        public List<Version> Versions { get; private set; }
        public VersionedModifications() => Versions = new();

        public void AddVersion(List<IFileProcessor> files)
        {
            var id = Guid.NewGuid();
            Versions.Add(new Version(id, files, Versions.Count()+1 ));
        }
        public VersionedModifications.Version GetVersion(Guid id) 
            => Versions.First(f => f.id == f.id);

        private bool AllFilesHaveSameCreationTimeInTicks(List<FileInfo> current, List<FileInfo> target )
            => target.Where(w => current.Any(x => x.CreationTime.Ticks == w.CreationTime.Ticks)).Count() == current.Count();
    } 
}
