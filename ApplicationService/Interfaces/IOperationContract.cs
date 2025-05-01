using FileManager.DAO;


namespace ApplicationService.Interfaces
{
    public interface IOperationContract
    {
        List<FileIdentity> GetFiles(); 
        string GetDirectory();
        object GetInstance();
    }
}
