using System.Threading.Tasks;

namespace Rm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.PageToolbars;

public interface IPageToolbarManager
{
    Task<PageToolbarItem[]> GetItemsAsync(PageToolbar toolbar);
}
