﻿using System.Threading.Tasks;

namespace Rm.Abp.Account.Web.ProfileManagement;

public interface IProfileManagementPageContributor
{
    Task ConfigureAsync(ProfileManagementPageCreationContext context);
}
