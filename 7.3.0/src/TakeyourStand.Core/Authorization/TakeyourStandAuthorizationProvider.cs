using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace TakeyourStand.Authorization
{
    public class TakeyourStandAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_MstAutoGenratedBarcodeType, L("MstAutoGenratedBarcodeType"));
            context.CreatePermission(PermissionNames.Pages_MstInventyoryNotification, L("MstInventyoryNotification"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TakeyourStandConsts.LocalizationSourceName);
        }
    }
}
