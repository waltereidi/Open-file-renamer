using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Interfaces
{
    public interface IVersionControl
    {
        public List<VersionedModifications.Version> GetAllVersion();
        public VersionedModifications.Version GetVersionById(Guid id);

    }
}
