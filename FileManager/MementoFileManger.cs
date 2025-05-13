using FileManager.DAO;
using FileManager.FileOperations;
using FileManager.Interfaces;
using System.Net.Http.Headers;

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
            => new FileWriter(_versioning.GetVersionForRollback())
                .Rollback(current);

        public Task Rollback()
        {
            var current = _versioning.GetVersion()
                .Select(s => FileIdentity.Instance(new(Path.Combine(s.GetDirectory().FullName, s.GetRenameTo()))))
                .ToList();
           
            return Rollback(current);
        }
             
        public List<IFileProcessor> GetVersion()
            => _versioning.GetVersion();

        private Task ExecuteOperation(List<IFileProcessor> files) 
            => new FileWriter(files).Start();
    }
}
