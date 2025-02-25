using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface ITabControl
    {
        public T GetTabContent<T>();
        public TabPage TabGetInstance();

    }
}
