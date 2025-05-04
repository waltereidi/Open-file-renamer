using FileManager.DAO;

namespace ApplicationService.Contracts
{
    public class AppendToEnd : OperationContract
    {
        public string _text { get; private set; }
        public AppendToEnd(string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _text = text;
        }
    }
}
