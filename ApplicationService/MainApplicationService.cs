using ApplicationService.Contracts;
using ApplicationService.DTO;
using ApplicationService.Enum;
using FileManager;
using FileManager.DAO;
using FileManager.Interfaces;
using Presentation.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace ApplicationService; 

public class MainApplicationService
{

    public MainApplicationService()
    {
    }
    public List<IFileProcessor> GetPreview(IOperationContract contract )
    {
        FileManagerService fm = new( new(contract.GetDirectory()));
        return Command( contract , fm , true) ?? throw new ArgumentNullException(); 
    }
    private List<IFileProcessor>? Command(IOperationContract contract, FileManagerService fm , bool preview) 
        => contract.GetInstance() 
        switch 
        {
            NumberedSequenceBefore e => 
                preview 
                ? fm.GetNumberedSequenceBeforePreview(contract.GetFiles(), e._Separator) 
                : fm.GetNumberedSequenceBefore(contract.GetFiles(), e._Separator).IsCompletedSuccessfully 
                    ? null
                    : throw new Exception(),
            NumberedSequenceAfter e =>
                preview
                ? fm.GetNumberedSequenceAfterPreview(contract.GetFiles(), e._Separator)
                : fm.GetNumberedSequenceAfter(contract.GetFiles(), e._Separator).IsCompletedSuccessfully
                    ? null
                    : throw new Exception(),
            //Place here more operations call
            _ => throw new InvalidOperationException()
        };
    public void RenameFiles(IOperationContract contract)
    {
        FileManagerService fm = new(new(contract.GetDirectory()));
        Command(contract, fm, false);
    }

    public MainApplicationServiceDTO.RollbackMessage RollBackVersion(Guid id ,List<FileIdentity> files ,string directory )
    {
        IVersionControl fm = new FileManagerService(new(directory));
        var task =fm.RollbackOperation(files , id);
        
        return new(task.IsCompletedSuccessfully ? "Success" : "Error");
    }
    public List<FileInfo> SearchFiles(string searchText, string directory, Main_SearchFilter? filter = null)
    => new FileManagerService(new DirectoryInfo(directory)).GetFilesContains(searchText);
    public List<FileInfo> SearchFilesFromSize(long? size, string directory, Main_SearchFilter? filter = null)
    {
        IDirectoryReader fm = new FileManagerService(new DirectoryInfo(directory));

        switch (filter)
        {
            case Main_SearchFilter.SmallerThan:
                return fm.GetFilesSmallerThan(size);
            case Main_SearchFilter.BiggerThan:
                return fm.GetFilesGreaterThan(size);
            default: throw new InvalidOperationException();
        }
    }
    //public List<IFileProcessor> GetNumberedSequenceAfterPreview
    //    (
    //        string directory,
    //        string separator,
    //        List<FileIdentity> files
    //    )
    //{
    //    INumberedSequence fm = new FileManagerService(new DirectoryInfo(directory));
    //    return fm.GetNumberedSequenceAfterPreview(files, separator);
    //}
    //public List<IFileProcessor> GetNumberedSequenceBeforePreview(string directory, string separator, List<FileIdentity> files)
    //{
    //    INumberedSequence fm = new FileManagerService(new DirectoryInfo(directory));
    //    return fm.GetNumberedSequenceBeforePreview(files , separator);
    //}
    public List<Tuple<Guid, int>> GetVersions(string directory)
    {
        IVersionControl vc = new FileManagerService(new(directory));
        return vc.GetAllVersion()
            .Select(s => new Tuple<Guid, int>(s.id, s.order))
            .ToList();
    }
    public VersionedModifications.Version GetVersionById(string directory, Guid id)
    {
        IVersionControl vc = new FileManagerService(new(directory));
        return vc.GetVersionById(id);
    }





}
