using ApplicationService.Enum;
using FileManager;
using FileManager.DirectoryOperations;
using FileManager.Interfaces;
using System.Runtime.CompilerServices;

namespace ApplicationService; 

public class MainApplicationService
{
    private readonly IFileManager _fileManager;


    public MainApplicationService()
    {
        _fileManager = new FileManagerService();

    }

    public List<FileInfo> SearchFiles(string searchText,string directory, Main_SearchFilter? filter = null )
    {
        var dr = new DirectoryReader(new(directory));
        return dr.GetFilesContains(searchText);
    }
    public List<FileInfo> SearchFilesFromSize(long? size, string directory, Main_SearchFilter? filter = null)
    {
        var dr = new DirectoryReader(new(directory));

        switch(filter)
        {
            case Main_SearchFilter.SmallerThan: 
                return dr.GetFilesSmallerThan(size);
            case Main_SearchFilter.BiggerThan:
                return dr.GetFilesGreaterThan(size);
            default: throw new InvalidOperationException();
        }
    }



}
