using Rm.Abp.Account.Web.Pages.Account;
using Volo.Abp.Identity;
using AutoMapper;
using Rm.Abp.Account.Web.Pages.Account.Components.ProfileManagementGroup.PersonalInfo;
using Volo.Abp.Account;

namespace Rm.Abp.Account.Web;

public class AbpAccountWebAutoMapperProfile : Profile
{
    public AbpAccountWebAutoMapperProfile()
    {
        CreateMap<ProfileDto, AccountProfilePersonalInfoManagementGroupViewComponent.PersonalInfoModel>()
            .MapExtraProperties();
    }
}
