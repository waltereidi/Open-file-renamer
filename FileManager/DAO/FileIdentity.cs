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
        private FileIdentity(FileInfo fi )
        {
            Id = fi.CreationTime.Ticks;
        }
        public static FileIdentity Instance(FileInfo fi) => new FileIdentity(fi);
        public bool Equals(FileInfo fi) => Id == fi.CreationTime.Ticks;
    }
}
