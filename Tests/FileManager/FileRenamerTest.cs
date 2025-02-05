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
                    Path.Combine(base._testDirPath.FullName, "TestFiles", "testfile.txt")
                );
        }
        [Fact]
        public void TestNumberSequenceBeforeExtension()
        {
            FileRenamer fr = new(_testFile.FullName );
            
            fr.NumberSequenceBeforeExtension(1);

            Assert.Equal("testfile1.txt", fr._renameTo);
        }
    }
}