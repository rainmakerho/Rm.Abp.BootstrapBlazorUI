using Rm.Abp.IdentityManagement.Blazor.BootstrapBlazorUI;
using Rm.Abp.PermissionManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Rm.Abp.IdentityManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpIdentityBlazorBootstrapBlazorModule),
    typeof(AbpPermissionManagementBlazorBootstrapBlazorModule)
)]
public class AbpIdentityBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
