using FileManager.DAO;
using FileManager.FileOperations;
using FileManager.Interfaces;

namespace FileManager
{
    public class MementoFileManger : IMementoFileManager
    {
        private static VersionedModifications _versioning = new VersionedModifications();

        public Task SetState(List<IFileProcessor> files) 
        {
            _versioning.AddVersion(files);

            return ExecuteOperation(files);
        }
        public Task Rollback(List<FileIdentity> current)
        {
            //var elegibleFiles = _versioning.GetVersion().Where(x=>x.IsFile());
            
            
            return null;
            //=> new FileWriter(_versioning.GetVersion())
            //.Rollback(current);
        }
            

        private Task ExecuteOperation(List<IFileProcessor> files) 
            => new FileWriter(files).Start();

        
    }
}
