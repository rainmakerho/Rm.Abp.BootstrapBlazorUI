using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme.Bundling;

public interface IComponentBundleManager
{
    Task<IReadOnlyList<string>> GetStyleBundleFilesAsync(string bundleName);

    Task<IReadOnlyList<string>> GetScriptBundleFilesAsync(string bundleName);
}
