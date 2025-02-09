using FileManager.DirectoryOperations;
using FileManager.FileOperations;
using FileManager.Interfaces;


namespace FileManager
{
    public class FileManagerService : IFileManager, IDirectoryReader
    {
        private readonly IMementoFileManager _memento = new MementoFileManger();
        private readonly DirectoryReader _dir;
        public FileManagerService(DirectoryInfo dr) => _dir = new DirectoryReader(dr);
        public List<FileInfo> GetFiles() => _dir.GetFiles();
        public List<FileInfo> GetFilesContains(string text) => _dir.GetFilesContains(text);
        public List<FileInfo> GetFilesGreaterThan(long? size) => _dir.GetFilesGreaterThan(size);
        public List<FileInfo> GetFilesSmallerThan(long? size) => _dir.GetFilesSmallerThan(size);


        public async Task NumberSequenceBeforeExtension(List<FileInfo> files, string separator)
        {
            List<IFileProcessor> list = files.Select((value, i)
                => {
                    IFileProcessor p = new NumberSequenceBeforeExtension(_dir._dir, value, i, separator);
                    return p;
                }).ToList();
            
            await _memento.SetState(list);
        }
        public async Task RollbackOperation(List<FileInfo> fi , Guid version)
            => await _memento.Rollback(version, fi);


    }
}
