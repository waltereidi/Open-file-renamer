﻿using FileManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.FileOperations
{
    public class AppendToEnd : FileProcessor
    {
        private readonly string? _text;
        public AppendToEnd
        (
            DirectoryInfo path, 
            FileIdentity fi, 
            string? text = null
        ) : base(path, fi)
        {
            _text = text; 
        }



        public override string GetRenameTo()
        {
            string nameWithouthExtension = base.FileNameBefore
                .Substring(0, base.FileNameBefore.LastIndexOf('.'));

            return String.Concat
                (
                    nameWithouthExtension,
                    _text,
                    base.FileExtensionBefore
                );
        }
    }
}
