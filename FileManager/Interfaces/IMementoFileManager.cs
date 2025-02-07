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
        public VersionedModifications.Version GetStateById(Guid id);
        public List<VersionedModifications.Version> GetAll();
        public void SetState(List<IFileProcessor> state);

    }
}
