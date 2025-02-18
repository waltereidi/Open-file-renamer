using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DAO
{
    /// <summary>
    /// Immutable class representing file identity
    /// </summary>
    public class FileIdentity
    {
        public readonly long Id;
        public readonly DirectoryInfo Dir;
        private FileIdentity(FileInfo fi )
        {
            Id = fi.CreationTime.Ticks;
            Dir = fi.Directory ?? throw new Exception(nameof(fi));
        }
        public static FileIdentity Instance(FileInfo fi) => new FileIdentity(fi);
        public static FileIdentity Instance(string id , DirectoryInfo di)
        {
            var file = di.GetFiles().First(x=> x.CreationTime.Ticks.ToString() == id);
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

        public FileInfo GetFile() => Dir.GetFiles().First(x => this.Equals(x) );
        public bool Equals(FileInfo fi) => Id == fi.CreationTime.Ticks;
        public bool Equals(string id ) => Id.ToString() == id;

    }
}
