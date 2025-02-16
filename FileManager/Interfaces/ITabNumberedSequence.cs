using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Interfaces
{
    public interface ITabNumberedSequence
    {
        public void NumberedSequenceBeforeChecked(object sender, EventArgs e);
        public void NumberedSequenceAfterChecked(object sender, EventArgs e);
        public void TextAppendChanged(object sender, EventArgs e);
    }
}
