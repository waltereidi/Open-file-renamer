using FileManager.DAO;
using Presentation.Interfaces;
using System.Collections.Generic;

namespace ApplicationService.Contracts
{
    public class NumberedSequenceBefore : OperationContract
    {

        public string _Separator { get; private set; }
        public NumberedSequenceBefore(string separator , List<FileIdentity> files , string dir ) 
            : base( dir , files)
        {
            _Separator = separator;
        }
    }
}
