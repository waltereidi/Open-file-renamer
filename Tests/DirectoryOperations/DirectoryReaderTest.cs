using FileManager.DirectoryOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DirectoryOperations
{
    public class DirectoryReaderTest
    {
       
        public DirectoryReaderTest() { }

        [Fact]
        public void GetFilesReturnsFilesInFolder() 
        {
            DirectoryReader dr = new(new("C:/"));
            
            var files = dr.GetFiles();
            
            Assert.True(files.Count() > 0 );
        }
        /// <summary>
        /// Describes how to setup a filter to be given in this method,
        /// </summary>
        [Fact]
        public void GetFilesWithFilterReturnsFiles()
        {
            DirectoryReader dr = new(new("C:/"));
            
            var files = dr.GetFilesContains("Files" );

            Assert.True(files.Count() > 0);
        }
    }
}
