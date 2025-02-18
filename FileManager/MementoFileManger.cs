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
        
        public List<VersionedModifications.Version> GetAllVersions() 
            => _versioning.Versions;
        public Task SetState(List<IFileProcessor> files) 
        {
            if (!_versioning.Versions.Any()) 
            { 
                var original = new List<IFileProcessor>();
                files.ForEach(f => original.Add(new OriginalFile( f.GetDirectory(), f.GetIdentity())));
                _versioning.AddVersion(original);
            }
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
