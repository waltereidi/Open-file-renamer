using ApplicationService.Contracts;
using ApplicationService.DTO;
using ApplicationService.Enum;
using ApplicationService.Interfaces;
using FileManager;
using FileManager.DAO;
using FileManager.Interfaces;

namespace ApplicationService; 

public class MainApplicationService
{

    public MainApplicationService()
    {
    }
    public List<IFileProcessor> GetPreview(IOperationContract contract )
    {
        FileManagerService fm = new( new(contract.GetDirectory()));
        return CommandPreview( contract , fm ) ?? throw new ArgumentNullException(); 
    }
    private List<IFileProcessor> CommandPreview(IOperationContract contract, FileManagerService fm ) 
        => contract.GetInstance() 
        switch 
        {
            NumberedSequenceBefore e => fm.GetNumberedSequenceBeforePreview(contract.GetFiles(), e._Separator),
            NumberedSequenceAfter e => fm.GetNumberedSequenceAfterPreview(contract.GetFiles(), e._Separator),
            AppendAt e => fm.GetAppendAtPreview(contract.GetFiles(), e._position, e._text),
            AppendToEnd e => fm.GetAppendToEndPreview(contract.GetFiles(), e._text),
            AppendToStart e => fm.GetAppendToStartPreview(contract.GetFiles(), e._text),
            ReplacePattern e => fm.GetReplacePatternPreview(contract.GetFiles(), e._pattern, e._text),
            ToLowerPattern e => fm.GetToLowerPatternPreview(contract.GetFiles()),
            ToUpperPattern e => fm.GetToUpperPatternPreview(contract.GetFiles()),
            RegexPattern e => fm.GetRegexPatternPreview(contract.GetFiles(), e._pattern, e._text),
            //Place here more operations call
            _ => throw new InvalidOperationException()
        };
    private Task CommandRename(IOperationContract contract, FileManagerService fm)
      => contract.GetInstance()
      switch
      {
          NumberedSequenceBefore e => fm.GetNumberedSequenceBefore(contract.GetFiles(), e._Separator),
          NumberedSequenceAfter e => fm.GetNumberedSequenceAfter(contract.GetFiles(), e._Separator),
          AppendAt e => fm.GetAppendAt(contract.GetFiles(), e._position, e._text),
          AppendToEnd e => fm.GetAppendToEnd(contract.GetFiles(), e._text),
          AppendToStart e => fm.GetAppendToStart(contract.GetFiles(), e._text),
          //Place here more operations call
          _ => throw new InvalidOperationException()
      };
    public void RenameFiles(IOperationContract contract)
    {
        FileManagerService fm = new(new(contract.GetDirectory()));
        CommandRename(contract, fm);
    }

    public MainApplicationServiceDTO.RollbackMessage RollBackVersion(Guid id ,List<FileIdentity> files ,string directory )
    {
        IVersionControl fm = new FileManagerService(new(directory));
        Task.Run(() => fm.RollbackOperation(files , id));
        
        return new(true ? "Success" : "Error");
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
