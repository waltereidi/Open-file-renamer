using FileManager.DAO;
using FileManager.FileOperations;
using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FileManager.DAO.VersionedModifications;

namespace FileManager
{
    public class FileManagerService : IFileManager
    {
        private readonly MementoFileManger _memento = new MementoFileManger();
        public FileManagerService()
        {
        }

        public async Task NumberSequenceBeforeExtension(List<FileInfo> files , string separator )
        {


        }
        public async Task RollbackOperation(List<FileInfo> fi , Guid version)
        {
            VersionedModifications.Version old = _memento.GetStateById(version);

        }

        //public bool EnsureRollBackCanHappen(List<FileInfo> current, Guid id)
        //{
        //    if (!Versions.Any(f => f.id == id))
        //        return false;

        //    var target = Versions.First(f => f.id == f.id);

        //    if (!AllFilesHaveSameCreationTimeInTicks(current, target.files))
        //        return false;

        //    //Add here additional checks to ensure rollback can happen
        //    return true;
        //}

    }
}
