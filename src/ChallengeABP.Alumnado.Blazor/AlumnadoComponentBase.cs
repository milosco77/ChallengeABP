using ChallengeABP.Alumnado.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ChallengeABP.Alumnado.Blazor
{
    public abstract class AlumnadoComponentBase : AbpComponentBase
    {
        protected AlumnadoComponentBase()
        {
            LocalizationResource = typeof(AlumnadoResource);
        }
    }
}
