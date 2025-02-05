using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Interfaces
{
    public interface IFileProcessor
    {
        public abstract Task<Action> Start();
        public abstract Task<Action> EnsureSuccessfullOperation();
    }
}
