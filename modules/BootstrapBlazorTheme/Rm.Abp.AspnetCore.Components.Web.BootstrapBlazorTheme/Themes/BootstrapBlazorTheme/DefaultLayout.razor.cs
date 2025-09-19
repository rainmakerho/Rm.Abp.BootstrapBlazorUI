using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Rm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Settings;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Rm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Themes.BootstrapBlazorTheme;

public partial class DefaultLayout
{
    [Inject] protected IBootstrapBlazorSettingsProvider BootstrapBlazorSettingsProvider { get; set; }

    [Inject] protected IMenuManager MenuManager { get; set; }

    private bool UseTabSet { get; set; } = true;

    private string Theme { get; set; } = "";

    private bool IsOpen { get; set; }

    private bool IsFixedHeader { get; set; } = true;

    private bool IsFixedTabHeader { get; set; } = true;

    private bool IsFixedFooter { get; set; } = true;

    private bool IsFullSide { get; set; } = true;

    private bool ShowFooter { get; set; } = true;

    private bool ShowTabInHeader { get; set; } = true;

    private List<MenuItem>? Menus { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetMenuAsync();
        //Menus = GetIconSideMenuItems();
    }

    private static List<MenuItem> GetIconSideMenuItems()
    {
        var menus = new List<MenuItem>
        {
            new() { Text = "返回组件库", Icon = "fa-solid fa-fw fa-home", Url = "https://www.blazor.zone/components" },
            new() { Text = "Index", Icon = "fa-solid fa-fw fa-flag", Url = "/" , Match = NavLinkMatch.All},
            new() { Text = "Counter", Icon = "fa-solid fa-fw fa-check-square", Url = "/counter" },
            new() { Text = "Weather", Icon = "fa-solid fa-fw fa-database", Url = "/weather" },
            new() { Text = "Table", Icon = "fa-solid fa-fw fa-table", Url = "/table" },
            new() { Text = "花名册", Icon = "fa-solid fa-fw fa-users", Url = "/users" }
        };

        return menus;
    }
    private async Task GetMenuAsync()
    {
        MenuItem InFunc(ApplicationMenuItem menuItem)
        {
            var menu = new MenuItem
            {
                Text = menuItem.DisplayName,
                Icon = menuItem.Icon,
                Url = menuItem.Url == null ? "#" : menuItem.Url.TrimStart('~'),
                Target = menuItem.Target,
            };
            menu.Items = menuItem.Items.Select(InFunc).ToList();

            return menu;
        }

        var mainMenu = await MenuManager.GetMainMenuAsync();
        Menus = mainMenu.Items.Select(InFunc).ToList();
    }

    private Task OnSideChanged(bool v)
    {
        IsFullSide = v;
        StateHasChanged();
        return Task.CompletedTask;
    }
}