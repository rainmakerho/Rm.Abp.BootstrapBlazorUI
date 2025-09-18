using Rm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Rm.Abp.SettingManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Rm.Abp.SettingManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpSettingManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpSettingManagementBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
