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
            => new FileIdentity(di.GetFiles().First(x => Id.Equals(x)));
        public FileInfo GetFile() => Dir.GetFiles().First(x => Id.Equals(x) );
        public bool Equals(FileInfo fi) => Id == fi.CreationTime.Ticks;
    }
}
