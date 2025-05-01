using FileManager.DAO;

namespace ApplicationService.Contracts
{
    public class ReplacePattern : OperationContract
    {

        public string _pattern { get; private set; }
        public string _text { get; private set; }
        public ReplacePattern(string pattern , string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _pattern = pattern;
            _text = text;
        }
    }
}
