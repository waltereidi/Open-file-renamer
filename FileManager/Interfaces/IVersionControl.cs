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
        public Task RollbackOperation(List<FileIdentity> fi);
        public Task RollbackOperation();
        public List<IFileProcessor> GetPreviousVersion();
    }
}
