using ApplicationService.Enum;
using FileManager;
using FileManager.Interfaces;

namespace ApplicationService; 

public class MainApplicationService
{

    public MainApplicationService()
    {
    }

    public List<IFileProcessor> GetNumberedSequenceAfterPreview(string directory,  string separator)
    {
        IFileManager fm = new FileManagerService(new DirectoryInfo(directory));


    }

    public List<FileInfo> SearchFiles(string searchText,string directory, Main_SearchFilter? filter = null )
        => new FileManagerService(new DirectoryInfo(directory)).GetFilesContains(searchText);
    public List<FileInfo> SearchFilesFromSize(long? size, string directory, Main_SearchFilter? filter = null)
    {
        IFileManager fm = new FileManagerService(new DirectoryInfo(directory));

        switch(filter)
        {
            case Main_SearchFilter.SmallerThan: 
                return fm.GetFilesSmallerThan(size);
            case Main_SearchFilter.BiggerThan:
                return fm.GetFilesGreaterThan(size);
            default: throw new InvalidOperationException();
        }
    }



}
