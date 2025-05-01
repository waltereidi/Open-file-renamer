using ApplicationService.Interfaces;
using FileManager.DAO;

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

        public object GetInstance()
            => this;
    }
}
