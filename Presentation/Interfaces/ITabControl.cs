using ApplicationService.Interfaces;

namespace Presentation.Interfaces
{
    public interface ITabControl
    {
        public IOperationContract GetTabContent();
        public TabPage GetInstance();
        public void GetPreview(object sender, EventArgs e);

    }
}
