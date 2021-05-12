using ChallengeABP.Alumnado.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ChallengeABP.Alumnado.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AlumnadoController : AbpController
    {
        protected AlumnadoController()
        {
            LocalizationResource = typeof(AlumnadoResource);
        }
    }
}