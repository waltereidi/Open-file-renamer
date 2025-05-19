using FileManager.Interfaces;

namespace FileManager.DAO
{
    public class VersionedModifications
    {
        private Guid Id { get; set; }
        private List<IFileProcessor> Files { get; set; } 
        private int Order { get; set; } = 0;
        private bool IsRollback { get; set; } = false; 
        public List<IFileProcessor> GetVersionForRollback()
        {
            if (IsRollback)
                throw new InvalidOperationException("Rollback is no longer available");

            IsRollback = true;
            return Files;
        }
        public List<IFileProcessor> GetVersion() => Files;
                    
        public void AddVersion(List<IFileProcessor> files)
        {
            Id = new Guid();
            Files = files;
            Order = 0;
            IsRollback = false;
        }
    } 
}
