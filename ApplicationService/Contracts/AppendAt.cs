using FileManager.DAO;
using Presentation.Interfaces;

namespace ApplicationService.Contracts
{
    public class AppendAt : OperationContract
    {

        public long _position { get; private set; }
        public AppendAt(long position, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _position= position;
        }
    }
}
