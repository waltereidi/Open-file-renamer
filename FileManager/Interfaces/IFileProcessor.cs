using FileManager.DAO;

namespace FileManager.Interfaces
{
    public interface IFileProcessor
    {
        public Task Start();
        public string GetRenameTo();
        public Task Revert();
        public FileIdentity GetIdentity();
        public DirectoryInfo GetDirectory();
    }
}
