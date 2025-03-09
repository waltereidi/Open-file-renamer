using FileManager;
using FileManager.DAO;

namespace Tests.FileManager
{
    public class FileManagerServiceTest : Configuration
    {
        private readonly FileManagerService _service;
        private List<FileIdentity> _files;
        public FileManagerServiceTest() 
        {
            _service = new FileManagerService(base._testDirPath);
            var files = base._testDirPath.GetFiles().ToList();
            _files = FileIdentity.Instances(files.Select(f => f.FullName).ToList()
                , files.First().Directory ?? throw new ArgumentNullException());
        }
        [Fact]
        public void TestNumberSequenceBeforeExtensionPreview()
        {
            var list = _service.GetNumberedSequenceBeforePreview(_files, "_");

            list.ForEach(f => Assert.True( f.GetRenameTo().Contains("_")));
        }
        [Fact]
        public void TestAppendAtPreview()
        {
            var list = _service.GetAppendAtPreview(_files, 2 ,"_");

            var results = list.Select(s => s.GetRenameTo()).ToList();

            list.ForEach(f => Assert.True(f.GetRenameTo().Substring(2 ).Contains("_")));
        }


    }

}
