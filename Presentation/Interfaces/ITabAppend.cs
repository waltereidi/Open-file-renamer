using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface ITabAppend : ITabControl
    {
        public void ApplyClickEvent(object sender, EventArgs e);
    }
}
