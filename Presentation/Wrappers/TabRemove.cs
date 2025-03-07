using Presentation.Interfaces;
using Presentation.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Wrappers
{
    public class TabRemoveWrapper : TabController
    {
        public TabRemoveWrapper(DataGridView_Files preview, DataGridView_Files selection, TabPage tab, Label dir) : base(preview, selection, tab, dir)
        {
        }

        public override IOperationContract GetTabContent()
        {
            throw new NotImplementedException();
        }
    }
}
