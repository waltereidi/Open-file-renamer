using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class DirectoryReader
    {
        private readonly DirectoryInfo _dir;
        public DirectoryReader( DirectoryInfo dir )
        {
            _dir = dir; 
        }

    }
}
