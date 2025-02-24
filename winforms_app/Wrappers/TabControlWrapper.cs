using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Wrappers
{
    public class TabControlWrapper : ITabControlWrapper
    {
        private readonly List<ITabControl> _tabs;
        private readonly TabControl _tabControl; 
        public TabControlWrapper(TabControl tabControl , List<ITabControl> tabs)
        {
            _tabControl = tabControl;
            _tabs = tabs;
        }




    }
}
