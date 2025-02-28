using ApplicationService.Enum;
using FileManager.DAO;


namespace Presentation.Interfaces
{
    public interface IOperationContract
    {
        List<FileIdentity> GetFiles(); 
        string GetDirectory();
        object GetInstance();
    }
}
