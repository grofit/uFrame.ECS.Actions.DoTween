using System.Text;
using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Set Time Scale")]
    [ActionDescription("Sets the global time scale for all tweens")]
    public class SetTweenTimeScale : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public float TimeScale;
        
        public override void Execute()
        {
            Tween.timeScale = TimeScale;
        }
    }
}