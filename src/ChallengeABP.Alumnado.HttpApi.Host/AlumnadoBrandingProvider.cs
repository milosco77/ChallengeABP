using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ChallengeABP.Alumnado
{
    [Dependency(ReplaceServices = true)]
    public class AlumnadoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Alumnado";
    }
}
