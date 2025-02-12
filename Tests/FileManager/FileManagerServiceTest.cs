using FileManager;

namespace Tests.FileManager
{
    public class FileManagerServiceTest : Configuration
    {
        private readonly FileManagerService _service;
        private List<FileInfo> _files;
        public FileManagerServiceTest() 
        {
            _service = new FileManagerService(base._testDirPath);
            _files = base._testDirPath.GetFiles().ToList();
        }
        [Fact]
        public void TestNumberSequenceBeforeExtensionPreview()
        {
            var list = _service.NumberSequenceBeforeExtensionPreview(_files, "_");

            list.ForEach(f => Assert.True( f.GetRenameTo().Contains("_")));
            
        }
        [Fact]
        public async void TestNumberSequenceBeforeExtension()
        {
            await _service.NumberSequenceBeforeExtension(_files, "_");

            _files.ForEach(f => Assert.True(!f.Name.Contains("_")));
        }
        /// <summary>
        /// Asserts that a file modified has its original name returned after rollback <br></br>
        /// Thread sleep is a mechanism to prevent re-read the file before been released from disk<br></br>
        /// This issue should be fixed
        /// </summary>
        [Fact]
        public async void TestModifySomethingAndRollback()
        {
            var firstFileNameForAssert = _files.First().FullName;
            await _service.NumberSequenceBeforeExtension(_files, "_");

            var versions = _service.GetAllVersions();
            var originalFiles = versions.First().id;

            await _service.RollbackOperation(_files , originalFiles);
            //Place a breakpoint here to assert file name has changed
            
            Thread.Sleep(100);
            var test = new FileInfo(firstFileNameForAssert);
            Assert.True(test.Exists);
        }

    }

}
