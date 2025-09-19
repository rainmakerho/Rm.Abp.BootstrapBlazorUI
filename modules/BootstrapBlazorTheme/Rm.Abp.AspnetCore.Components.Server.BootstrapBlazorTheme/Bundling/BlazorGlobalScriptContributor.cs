using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Rm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme.Bundling;

public class BlazorGlobalScriptContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("_content/BootstrapBlazor/js/bootstrap.blazor.bundle.min.js");
        context.Files.AddIfNotContains("_framework/blazor.web.js");
    }
}
