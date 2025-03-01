using FileManager.DAO;
using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public class FileWriter
    {
        private List<IFileProcessor> _file;
        public FileWriter(List<IFileProcessor> file) => _file = file;
        public async Task Start()
        {
            try
            {
                var e = _file.Select(s => Task.Run(() => s.Start())).ToArray();
                await Task.WhenAll(e);
            }
            catch (Exception ex)
            {
                //var e = _file.Select(s => Task.Run(() => s.Revert())).ToArray();
                //await Task.WhenAll(e);
                //throw new Exception(ex.Message);
            }

        }
        public async Task Rollback(List<FileIdentity> current )
        {
            if(_file.Any(x => current.Any(a => x.GetIdentity().Equals(a))))
            {
                var canRollback = _file.Where(x => current.Select(s=> s.GetFile()).Any(a => x.GetIdentity().Equals(a)));
                canRollback.ToList();
                _file.Select(s => Task.Run(() => s.Start())).ToArray();
            }
            
            
        }
    }
}
