using FileManager.DAO;
using FileManager.FileOperations;
using FileManager.Interfaces;

namespace FileManager
{
    public class MementoFileManger : IMementoFileManager
    {
        private static VersionedModifications _versioning = new VersionedModifications();
        public  void ClearMemento() 
            => _versioning = new VersionedModifications();
        
        public List<VersionedModifications.Version> GetAll() 
            => _versioning.Versions;
        public Task SetState(List<IFileProcessor> files) 
        {
            _versioning.AddVersion(files);
            return ExecuteOperation(files);
        }
        public Task Rollback(Guid old , List<FileInfo> current) 
            => new FileWriter(_versioning.GetVersionById(old))
            .Rollback(current);

        private Task ExecuteOperation(List<IFileProcessor> files) 
            => new FileWriter(files).Start();
        
        

    }
}
