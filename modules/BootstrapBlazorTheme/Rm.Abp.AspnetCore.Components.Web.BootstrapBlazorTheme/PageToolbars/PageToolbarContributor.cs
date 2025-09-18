using System.Threading.Tasks;

namespace Rm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.PageToolbars;

public abstract class PageToolbarContributor : IPageToolbarContributor
{
    public abstract Task ContributeAsync(PageToolbarContributionContext context);
}
