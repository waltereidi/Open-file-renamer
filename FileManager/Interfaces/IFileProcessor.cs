namespace FileManager.Interfaces
{
    public interface IFileProcessor
    {
        public void Start();
        public string GetRenameTo();
        public FileInfo GetFile();
    }
}
