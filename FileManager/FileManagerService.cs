using FileManager.DAO;
using FileManager.DirectoryOperations;
using FileManager.FileOperations;
using FileManager.Interfaces;
using System.Collections.Generic;


namespace FileManager
{
    public class FileManagerService : IFileManager
    {
        private readonly IMementoFileManager _memento = new MementoFileManger();
        private readonly DirectoryReader _dir;
        public FileManagerService(DirectoryInfo dr) => _dir = new DirectoryReader(dr);
        public List<VersionedModifications.Version> GetAllVersions() => _memento.GetAllVersions();
        public List<FileInfo> GetFiles() => _dir.GetFiles();
        public List<FileInfo> GetFilesContains(string text) => _dir.GetFilesContains(text);
        public List<FileInfo> GetFilesGreaterThan(long? size) => _dir.GetFilesGreaterThan(size);
        public List<FileInfo> GetFilesSmallerThan(long? size) => _dir.GetFilesSmallerThan(size);

        public List<IFileProcessor> NumberSequenceBeforeExtensionPreview(List<FileInfo> files, string separator)
            => files.Select((value, i)
                =>{
                       IFileProcessor f = new NumberSequenceBeforeExtension(_dir._dir, value, i, separator);
                       return f;
                  }).ToList();
        public async Task NumberSequenceBeforeExtension(List<FileInfo> files, string separator)
            => await _memento.SetState(NumberSequenceBeforeExtensionPreview(files, separator));

        public async Task RollbackOperation(List<FileInfo> fi , Guid version)
            => await _memento.Rollback(version, fi);


    }
}
