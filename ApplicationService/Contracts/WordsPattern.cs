using FileManager.DAO;
using Presentation.Interfaces;

namespace ApplicationService.Contracts
{
    public class WordsPattern : OperationContract
    {

        public string _text { get; private set; }
        public WordsPattern(string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _text = text;
        }
    }
}
