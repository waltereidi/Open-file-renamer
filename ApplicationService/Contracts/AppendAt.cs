using FileManager.DAO;
using Presentation.Interfaces;

namespace ApplicationService.Contracts
{
    public class AppendAt : OperationContract
    {

        public long _position { get; private set; }
        public string _text { get; private set; }
        public AppendAt(long position, string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _position= position;
            _text = text;
        }
    }
}
