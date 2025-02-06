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

    public async Task<List<FileInfo>> ChangeSearchFilter(string searchText,string directory, Main_SearchFilter? filter = null )
    {
        var dr = new DirectoryReader(new(directory));


        switch(filter)
        {
            case Main_SearchFilter.Contains:
                return await dr.GetFilesContains(searchText);
                break;
            case Main_SearchFilter.GreaterThan:
                return await dr.GetFilesGreaterThan(int.Parse(searchText));
                break;
            case Main_SearchFilter.SmallerThan:
                return await dr.GetFilesSmallerThan(searchText);
                break;
            default:
                break;
        }

    }



}
