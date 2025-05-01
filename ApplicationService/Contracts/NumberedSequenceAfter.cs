using FileManager.DAO;

namespace ApplicationService.Contracts
{
    public class NumberedSequenceAfter : OperationContract
    {

        public string _Separator { get; private set; }
        public NumberedSequenceAfter(string separator, List<FileIdentity> files, string dir)
            : base(dir, files)
        {
            _Separator = separator;
        }
    }
}
