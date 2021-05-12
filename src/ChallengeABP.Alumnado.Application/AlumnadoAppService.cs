using System;
using System.Collections.Generic;
using System.Text;
using ChallengeABP.Alumnado.Localization;
using Volo.Abp.Application.Services;

namespace ChallengeABP.Alumnado
{
    /* Inherit your application services from this class.
     */
    public abstract class AlumnadoAppService : ApplicationService
    {
        protected AlumnadoAppService()
        {
            LocalizationResource = typeof(AlumnadoResource);
        }
    }
}
