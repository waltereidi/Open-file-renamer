using ApplicationService;
using Presentation.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Interfaces;

namespace Presentation.Wrappers
{
    public abstract class TabController : ITabControl
    {
        protected readonly Label _directory;
        protected readonly DataGridView_Files _previewGrid;
        protected readonly DataGridView_Files _selectionGrid;
        protected readonly MainApplicationService _service = new();
        protected readonly TabPage _tab; 
        public TabController(DataGridView_Files preview, DataGridView_Files selection, TabPage tab,Label dir ) 
        {
            _previewGrid = preview;
            _selectionGrid = selection;
            _tab = tab;
            _directory = dir;
        }

        public virtual void GetPreview(object sender, EventArgs e)
        {
            var files = _service.GetPreview(GetTabContent());
            _previewGrid.AddNewRowList(files, _selectionGrid);
        }

        public abstract IOperationContract GetTabContent();

        public virtual TabPage GetInstance() => _tab;
    }
}
