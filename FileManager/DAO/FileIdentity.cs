
namespace FileManager.DAO
{
    /// <summary>
    /// Immutable class representing file identity
    /// </summary>
    public class FileIdentity
    {
        public readonly string Id;
        public readonly DirectoryInfo Dir;
        public string GetId() => Id.ToString();
        private FileIdentity(FileInfo fi )
        {
            Id = fi.FullName;
            Dir = fi.Directory ?? throw new Exception(nameof(fi));
        }
        public static FileIdentity Instance(FileInfo fi) => new FileIdentity(fi);
        public static FileIdentity Instance(string id , DirectoryInfo di)
        {
            var file = di.GetFiles().First(x=> x.FullName == id);
            return Instance(file);
        }

        public static List<FileIdentity> Instances(List<string> listId, DirectoryInfo di)
        {
            var files = di.GetFiles();
            var fileIdentities = files.Select( s => FileIdentity.Instance(s) );

            
            return fileIdentities
                .Where(x => listId.Any(a => x.Equals(a) ) )
                .ToList();
        }

        public FileInfo GetFile() => Dir.GetFiles().Any(x => this.Equals(x))
            ? Dir.GetFiles().First(x => this.Equals(x) )
            : null ;
        public bool Equals(FileInfo fi) => Id == fi.FullName;
        public bool Equals(string id ) => Id.ToString() == id;

    }
}
