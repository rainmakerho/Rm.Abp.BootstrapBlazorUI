using Rm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Rm.Abp.FeatureManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Rm.Abp.FeatureManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpFeatureManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpFeatureManagementBlazorWebServerBootstrapBlazorModule : AbpModule
{
}
