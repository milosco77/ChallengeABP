using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ChallengeABP.Alumnado.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class AlumnadoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Alumnado";
    }
}
