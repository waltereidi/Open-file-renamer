﻿using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public class OriginalFile : FileProcessor
    {
        public OriginalFile(DirectoryInfo dr , FileIdentity fi ) : base( dr , fi )
        {

        }
        public override string GetRenameTo() => base.FileNameBefore;
        
    }
}
