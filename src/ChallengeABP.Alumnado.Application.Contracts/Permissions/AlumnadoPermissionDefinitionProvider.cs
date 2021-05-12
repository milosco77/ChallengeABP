using ChallengeABP.Alumnado.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ChallengeABP.Alumnado.Permissions
{
    public class AlumnadoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AlumnadoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AlumnadoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AlumnadoResource>(name);
        }
    }
}
