using System.Text;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Set Time Scale")]
    [ActionDescription("Sets the global time scale for all tweens")]
    public class SetGlobalTimeScale : UFAction
    {
        [In]
        public float TimeScale;
        
        public override void Execute()
        {
            DG.Tweening.DOTween.timeScale = TimeScale;
        }
    }
}