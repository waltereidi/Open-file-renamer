using FileManager.DAO;
using Presentation.Interfaces;

namespace ApplicationService.Contracts
{
    public class ToUpperPattern : OperationContract
    {

        public int _position { get; private set; }
        public string _text { get; private set; }
        public ToUpperPattern(int position, string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _position= position;
            _text = text;
        }
    }
}
