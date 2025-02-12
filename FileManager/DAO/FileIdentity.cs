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
            Dir = fi.Directory;
        }
        public static FileIdentity Instance(FileInfo fi) => new FileIdentity(fi);
        public static FileIdentity Instance(string Id , DirectoryInfo di)
        {
            var file = di.GetFiles().First(x=> x.CreationTime.Ticks.ToString() == Id);
            return Instance(file);
        }
        public FileInfo GetFile() => Dir.GetFiles().First(x => this.Equals(x) );
        public bool Equals(FileInfo fi) => Id == fi.CreationTime.Ticks;

    }
}
