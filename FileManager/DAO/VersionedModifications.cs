using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DAO
{
    public class VersionedModifications
    {
        public record Version(Guid id, List<FileInfo> files , int order);
        public List<Version> Versions { get; private set; }
        public VersionedModifications() => Versions = new();

        public void AddVersion(List<FileInfo> files)
        {
            var id = Guid.NewGuid();
            
            Versions.Add(new Version(id, files, Versions.Count()+1 ));
        }
        public VersionedModifications.Version GetVersion(Guid id) 
            => Versions.First(f => f.id == f.id);

        public bool EnsureRollBackCanHappen(List<FileInfo> current, Guid id)
        {
            if(!Versions.Any(f => f.id == id))
                return false;

            var target = Versions.First(f => f.id == f.id);

            if (!AllFilesHaveSameCreationTimeInTicks(current , target.files))
                return false;

            //Add here additional checks to ensure rollback can happen
            return true;
        }
        private bool AllFilesHaveSameCreationTimeInTicks(List<FileInfo> current, List<FileInfo> target )
            => target.Where(w => current.Any(x => x.CreationTime.Ticks == w.CreationTime.Ticks)).Count() == current.Count();
    } 
}
