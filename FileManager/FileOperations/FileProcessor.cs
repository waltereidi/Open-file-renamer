using FileManager.DAO;
using FileManager.Interfaces;


namespace FileManager.FileOperations
{
    public abstract class FileProcessor : IFileProcessor
    {
        public readonly FileIdentity Id;
        public readonly DirectoryInfo Dir;
        public readonly string FileNameBefore;
        public readonly string FileExtensionBefore;
        public FileProcessor(DirectoryInfo dr, FileIdentity fi)
        {
            var file = fi.GetFile();
            Dir = dr;
            Id = fi;
            FileNameBefore = file.Name;
            FileExtensionBefore = file.Extension;
            EnsureFileIsValid();
        }
        
        public abstract string GetRenameTo();

        public Task Start()
            => Task.Run(() => {
                var file = this.Id.GetFile();
                Operation(file);
                EnsureSuccessfullOperation();
            }); 

        public Task Revert()
            => Task.Run(() => {
                var file = this.Id.GetFile();
                RevertOperation();
                EnsureSuccessfullRevert();
            });
        private void EnsureSuccessfullRevert()
        {
            var file = this.Id.GetFile();
            if (!file.Exists)
                throw new FileNotFoundException("Error during revert operation, file does not exists");
            
            if(!file.Name.Equals(FileNameBefore))
                throw new IOException("Could not rename file back to its original name before operation");
        }
        private void RevertOperation()
            => this.Id.GetFile()
                .MoveTo(Path.Combine(Dir.FullName , FileNameBefore));

        private void Operation(FileInfo fi)
            => fi.MoveTo(Path.Combine(Dir.FullName, GetRenameTo()
               ?? throw new ArgumentNullException()));

        protected virtual void EnsureSuccessfullOperation()
        {
            var file = this.Id.GetFile();
            if (!file.Name.Equals(GetRenameTo()) || !file.Exists)
                throw new IOException($"Could not find a file named {GetRenameTo()}");
        }

        public virtual void EnsureFileIsValid()
        {
            if (!this.Id.GetFile().Exists)
                throw new FileNotFoundException();
        }
        public FileIdentity GetIdentity() => this.Id;
        public DirectoryInfo GetDirectory() => this.Dir;
    }
}
