using FileManager.DAO;
using FileManager.DirectoryOperations;
using FileManager.FileOperations.Append;
using FileManager.FileOperations.NumberedSequence;
using FileManager.FileOperations.Pattern;
using FileManager.FileOperations.Remove;
using FileManager.Interfaces;
using System.Collections.Generic;


namespace FileManager
{
    public class FileManagerService : IDirectoryReader, IVersionControl
    {
        private readonly IMementoFileManager _memento = new MementoFileManger();
        private readonly DirectoryReader _dir;
        public FileManagerService(DirectoryInfo dr) 
            => _dir = new DirectoryReader(dr);

        public List<FileInfo> GetFiles() => _dir.GetFiles();
        public List<FileInfo> GetFilesContains(string text) => _dir.GetFilesContains(text);
        public List<FileInfo> GetFilesGreaterThan(long? size) => _dir.GetFilesGreaterThan(size);
        public List<FileInfo> GetFilesSmallerThan(long? size) => _dir.GetFilesSmallerThan(size);

        public List<IFileProcessor> GetNumberedSequenceAfterPreview(List<FileIdentity> files, string separator)
            => files.Select((value, i)
                =>{
                       IFileProcessor f = new NumberSequenceAfterExtension(_dir._dir, value, i, separator);
                       return f;
                  }).ToList();
        public async Task GetNumberedSequenceAfter(List<FileIdentity> files, string separator)
            => await _memento.SetState(GetNumberedSequenceAfterPreview(files, separator));

        public async Task RollbackOperation(List<FileIdentity> fi )
            => await _memento.Rollback(fi);
        public async Task RollbackOperation()
                    => await _memento.Rollback();

        public List<IFileProcessor> GetNumberedSequenceBeforePreview(List<FileIdentity> files, string separator)
            => files.Select((value, i)
                =>
            {
                IFileProcessor f = new NumberSequenceBeforeExtension(_dir._dir, value, i, separator);
                return f;
            }).ToList();

        public async Task GetNumberedSequenceBefore(List<FileIdentity> files, string separator)
            => await _memento.SetState(GetNumberedSequenceBeforePreview(files, separator));


        public List<IFileProcessor> GetAppendAtPreview(List<FileIdentity> files, int position , string text)
            => files.Select((value, i)
                => {
                    IFileProcessor f = new AppendAt(_dir._dir, value,position ,text );
                    return f;
                }).ToList();

        public async Task GetAppendAt(List<FileIdentity> files, int position, string text)
            => await _memento.SetState(GetAppendAtPreview(files, position, text));

        public List<IFileProcessor> GetAppendToEndPreview(List<FileIdentity> files, string text)
            => files.Select((value, i)
                => {
                    IFileProcessor f = new AppendToEnd(_dir._dir, value, text);
                    return f;
                }).ToList();
        public async Task GetAppendToEnd(List<FileIdentity> files,string text)
            => await _memento.SetState(GetAppendToEndPreview(files, text));

        public List<IFileProcessor> GetAppendToStartPreview(List<FileIdentity> files, string text)
            => files.Select((value, i)
                => {
                    IFileProcessor f = new AppendToStart(_dir._dir, value, text);
                    return f;
                }).ToList();
        public async Task GetAppendToStart(List<FileIdentity> files, string text)
            => await _memento.SetState( GetAppendToStartPreview(files, text));

        public List<IFileProcessor> GetReplacePatternPreview(List<FileIdentity> files, string pattern , string text)
            => files.Select((value, i)
                => {
                    IFileProcessor f = new ReplacePattern(_dir._dir,value, pattern, text);
                    return f;
                }).ToList();

        //public List<IFileProcessor> GetWordsPatternPreview(List<FileIdentity> files, string pattern, string text)
        //    => files.Select((value, i)
        //        => {
        //            IFileProcessor f = new ReplacePattern(_dir._dir, value, pattern, text);
        //            return f;
        //        }).ToList();

        //public List<IFileProcessor> GetDigitsPatternPreview(List<FileIdentity> files, string text)
        //    => files.Select((value, i)
        //        => {
        //            IFileProcessor f = new AppendToStart(_dir._dir, value, text);
        //            return f;
        //        }).ToList();

        public List<IFileProcessor> GetRegexPatternPreview(List<FileIdentity> files,string regex, string text)
            => files.Select((value, i)
                => {
                    IFileProcessor f = new RegexPattern(_dir._dir, value, regex , text);
                    return f;
                }).ToList();

        public List<IFileProcessor> GetToLowerPatternPreview(List<FileIdentity> files)
            => files.Select((value, i)
                => {
                    IFileProcessor f = new ToLowerPattern(_dir._dir, value);
                    return f;
                }).ToList();

        public List<IFileProcessor> GetToUpperPatternPreview(List<FileIdentity> files)
            => files.Select((value, i)
                => {
                    IFileProcessor f = new ToUpperPattern(_dir._dir, value);
                    return f;
                }).ToList();
        public async Task GetToUpperPattern(List<FileIdentity> files)
            => await _memento.SetState(GetToUpperPatternPreview(files));

        public async Task GetToLowerPattern(List<FileIdentity> files)
            => await _memento.SetState(GetToLowerPatternPreview(files));

        public async Task GetRegexPattern(List<FileIdentity> files , string regex, string text)
            => await _memento.SetState(GetRegexPatternPreview(files , regex , text ));

        public async Task GetReplacePattern(List<FileIdentity> files, string pattern, string text)
            => await _memento.SetState(GetReplacePatternPreview(files , pattern ,text));


    }
}
