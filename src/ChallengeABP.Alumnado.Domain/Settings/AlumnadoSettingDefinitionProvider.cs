using Volo.Abp.Settings;

namespace ChallengeABP.Alumnado.Settings
{
    public class AlumnadoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AlumnadoSettings.MySetting1));
        }
    }
}
