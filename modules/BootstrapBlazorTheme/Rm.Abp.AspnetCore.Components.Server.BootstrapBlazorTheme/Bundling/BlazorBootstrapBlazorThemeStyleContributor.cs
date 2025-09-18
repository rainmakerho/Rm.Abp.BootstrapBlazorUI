using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Rm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme.Bundling;

public class BlazorBootstrapBlazorThemeStyleContributor: BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/_content/Rm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme/libs/abp/css/theme.css");
    }
}
