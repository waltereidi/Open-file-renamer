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
        public Task SetState(List<IFileProcessor> state);
        public Task Rollback(List<FileIdentity> current);
        public Task Rollback();
        public VersionedModifications.Version GetVersion();
    }
}
