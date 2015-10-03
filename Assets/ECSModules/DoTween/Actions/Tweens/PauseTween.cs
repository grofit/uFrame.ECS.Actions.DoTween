using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Pause Tween")]
    [ActionDescription("Pauses a given tween")]
    public class PauseTween : UFAction
    {
        [In]
        public Tween Tween;

        public override void Execute()
        {
            Tween.Pause();
        }
    }
}