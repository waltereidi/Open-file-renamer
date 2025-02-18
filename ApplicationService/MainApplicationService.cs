﻿using ApplicationService.Enum;
using FileManager;
using FileManager.DAO;
using FileManager.Interfaces;

namespace ApplicationService; 

public class MainApplicationService
{

    public MainApplicationService()
    {
    }

    public List<IFileProcessor> GetNumberedSequenceAfterPreview(string directory, string separator , List<FileIdentity> files)
    {
        INumberedSequence fm = new FileManagerService(new DirectoryInfo(directory));
        return fm.GetNumberedSequenceAfterPreview(files, separator);
    }
    public List<IFileProcessor> GetNumberedSequenceBeforePreview(string directory, string separator, List<FileIdentity> files)
    {
        INumberedSequence fm = new FileManagerService(new DirectoryInfo(directory));
        return fm.GetNumberedSequenceBeforePreview(files , separator);
    }

    public List<FileInfo> SearchFiles(string searchText,string directory, Main_SearchFilter? filter = null )
        => new FileManagerService(new DirectoryInfo(directory)).GetFilesContains(searchText);
    public List<FileInfo> SearchFilesFromSize(long? size, string directory, Main_SearchFilter? filter = null)
    {
        IDirectoryReader fm = new FileManagerService(new DirectoryInfo(directory));

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
