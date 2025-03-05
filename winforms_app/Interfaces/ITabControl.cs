using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface ITabControl
    {
        public IOperationContract GetTabContent();
        public TabPage GetInstance();
        public void GetPreview(object sender, EventArgs e);

    }
}
