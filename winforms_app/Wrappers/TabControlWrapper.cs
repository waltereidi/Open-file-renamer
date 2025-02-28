﻿using FileManager.Interfaces;
using Presentation.Interfaces;
using System.Windows.Forms;
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

        public IOperationContract GetSelectedTabData()
            => _tabs.ElementAt(_tabControl.SelectedIndex).GetTabContent();


    }
}
