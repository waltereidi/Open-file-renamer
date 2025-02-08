using FileManager.FileOperations; 

namespace Tests.FileManager
{
    public class FileRenamerTest : Configuration
    {
        private FileInfo _testFile;

        public FileRenamerTest()
        {
            _testFile = new FileInfo
                (
                    Path.Combine(base._testDirPath.FullName,  "testfile.txt")
                );
        }
        [Fact]
        public void TestNumberSequenceBeforeExtension()
        {
            var fr = FileRenamer.NumberSequenceBeforeExtension(base._testDirPath, _testFile ,1 , "_" );
            
            Assert.NotNull( fr);
        }
    }
}