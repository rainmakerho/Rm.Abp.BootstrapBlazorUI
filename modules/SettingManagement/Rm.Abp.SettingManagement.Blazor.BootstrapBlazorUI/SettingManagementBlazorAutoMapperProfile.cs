using AutoMapper;
using Volo.Abp.SettingManagement;

namespace Rm.Abp.SettingManagement.Blazor.BootstrapBlazorUI;

public class SettingManagementBlazorAutoMapperProfile : Profile
{
    public SettingManagementBlazorAutoMapperProfile()
    {
        CreateMap<EmailSettingsDto, UpdateEmailSettingsDto>();
    }
}
