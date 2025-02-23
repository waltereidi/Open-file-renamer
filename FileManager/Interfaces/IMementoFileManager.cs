using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Interfaces
{
    public interface IMementoFileManager
    {
        public void ClearMemento();
        public List<VersionedModifications.Version> GetAllVersions();
        public VersionedModifications.Version GetVersionById(Guid id);
        public Task SetState(List<IFileProcessor> state);
        public Task Rollback(Guid old, List<FileInfo> current);
    }
}
