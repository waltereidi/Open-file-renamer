using FileManager.DAO;
using Presentation.Interfaces;

namespace ApplicationService.Contracts
{
    public class DigitsPattern : OperationContract
    {

        public string _text { get; private set; }
        public DigitsPattern(string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _text = text;
        }
    }
}
