using FileManager.DAO;
using FileManager.FileOperations;
using FileManager.Interfaces;

namespace FileManager
{
    public class MementoFileManger : IMementoFileManager
    {
        public static VersionedModifications _versioning = new VersionedModifications();
        public  void ClearMemento() => _versioning = new VersionedModifications();
        public VersionedModifications.Version GetStateById(Guid id) => _versioning.GetVersion(id);
        public  List<VersionedModifications.Version> GetAll() => _versioning.Versions;
        public void SetState(List<IFileProcessor> files) 
        {
            _versioning.AddVersion(files);
        }


    }
}
