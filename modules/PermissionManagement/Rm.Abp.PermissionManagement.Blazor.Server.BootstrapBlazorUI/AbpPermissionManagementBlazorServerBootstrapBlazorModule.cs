using Rm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Rm.Abp.PermissionManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Rm.Abp.PermissionManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpPermissionManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpPermissionManagementBlazorServerBootstrapBlazorModule : AbpModule
{
}
