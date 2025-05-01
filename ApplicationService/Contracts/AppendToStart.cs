using FileManager.DAO;

namespace ApplicationService.Contracts
{
    public class AppendToStart : OperationContract
    {

        public string _text { get; private set; }
        public AppendToStart(string text, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _text = text;
        }

    }
}
