using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.FileManager.DAO
{
    public class FileIdentityTest : Configuration
    { 
        public FileIdentityTest()
        {

        }
        [Fact] // Ensure a fileinfo instance can return fileIdentity
        public void TestFileInstanceIdentityFromFileInfo()
        {
            var file = base._testDirPath.GetFiles().First();
            var instance = FileIdentity.Instance(file);

            Assert.NotNull(instance.Id); 
        }
        [Fact] //Ensure when instanced from a ID can return a existent file
        public void ExistentFileIdCanReturnNewFile()
        {
            var file = base._testDirPath.GetFiles().First(); 
            var instance = FileIdentity.Instance( file.CreationTime.Ticks.ToString() , _testDirPath );

            Assert.True(instance.GetFile().Exists);
        }
       
    }

    
}
