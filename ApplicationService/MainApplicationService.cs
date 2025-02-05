using ApplicationService.Enum;
using FileManager;
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

    public async Task ChangeSearchFilter(Main_SearchFilter filter , string searchText )
    {

    }




}
