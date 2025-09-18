using System.Threading.Tasks;

namespace Rm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Toolbars;

public interface IToolbarManager
{
    Task<Toolbar> GetAsync(string name);
}
