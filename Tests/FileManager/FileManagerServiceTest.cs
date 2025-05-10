using FileManager;
using FileManager.DAO;
using System.Text.RegularExpressions;

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
        public void TestAppendAtPatternPreview()
        {
            var list = _service.GetAppendAtPreview(_files, 2 ,"_");

            var results = list.Select(s => s.GetRenameTo()).ToList();

            list.ForEach(f => Assert.True(f.GetRenameTo().Substring(2 ).Contains("_")));
        }
        [Fact]
        public void TestReplacePatternPreview()
        {
            var list = _service.GetReplacePatternPreview(_files, "_", "");

            var results = list.Select(s => s.GetRenameTo()).ToList();

            list.ForEach(f => Assert.True(!f.GetRenameTo().Contains("_")));
        }
        [Fact]
        public void TestToLowerPatternPreview()
        {
            var list = _service.GetToLowerPatternPreview(_files);

            list.ForEach(f => Assert.True( 
                Regex.Match( 
                    f.GetRenameTo() , 
                    @"[A-Z]" , 
                    RegexOptions.None).Index < 1
                ));
        }
        [Fact]
        public void TestToUpperPatternPreview()
        {
            var list = _service.GetToUpperPatternPreview(_files);


            list.ForEach( f => Assert.True(
                Regex.Match(
                    f.GetRenameTo().Substring(0, f.GetRenameTo().LastIndexOf('.')),
                    @"[a-z]",
                    RegexOptions.None).Index < 1
                ));
        }
        [Fact]
        public void TestRollBackOperation()
        {
            var list = _service.GetToUpperPattern(_files);
            _service.RollbackOperation();
            
        }

    }

}
