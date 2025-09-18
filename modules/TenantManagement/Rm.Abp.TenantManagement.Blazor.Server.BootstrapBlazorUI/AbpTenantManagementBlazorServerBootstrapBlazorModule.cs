using Rm.Abp.FeatureManagement.Blazor.Server.BootstrapBlazorUI;
using Rm.Abp.TenantManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Rm.Abp.TenantManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpTenantManagementBlazorBootstrapBlazorModule),
    typeof(AbpFeatureManagementBlazorWebServerBootstrapBlazorModule)
)]
public class AbpTenantManagementBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
