using FileManager.DAO;

namespace ApplicationService.Contracts
{
    public class ToUpperPattern : OperationContract
    {

        public ToUpperPattern(List<FileIdentity> files, string dir)
            : base(dir, files)
        {
        }
    }
}
