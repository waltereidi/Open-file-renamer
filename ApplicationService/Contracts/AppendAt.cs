using FileManager.DAO;
using ApplicationService.Interfaces;

namespace ApplicationService.Contracts
{
    public class AppendAt : OperationContract
    {

        public int _position { get; private set; }
        public string _text { get; private set; }
        public AppendAt(int position, string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _position= position;
            _text = text;
        }
    }
}
