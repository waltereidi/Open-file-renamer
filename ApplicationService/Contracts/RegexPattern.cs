using FileManager.DAO;
using Presentation.Interfaces;

namespace ApplicationService.Contracts
{
    public class RegexPattern : OperationContract
    {

        public string _pattern { get; private set; }
        public string _text { get; private set; }
        public RegexPattern(string pattern, string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _pattern = pattern;
            _text = text;
        }
    }
}
