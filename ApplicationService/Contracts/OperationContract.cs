using FileManager.DAO;
using Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Contracts
{
    public class OperationContract : IOperationContract
    {
        private readonly List<FileIdentity> _Files;
        private readonly string _Directory;

        public OperationContract(string dir , List<FileIdentity> files) 
        {
            _Files = files;
            _Directory = dir;
        }
        public string GetDirectory()
            => _Directory;
        public List<FileIdentity> GetFiles()
            => _Files;
    }
}
