using FileManager.DAO;

namespace ApplicationService.Contracts
{
    public class ToLowerPattern : OperationContract
    {

        public ToLowerPattern( List<FileIdentity> files, string dir)
            : base(dir, files)
        {
        }
    }
}
