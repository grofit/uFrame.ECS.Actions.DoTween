using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Complete Tween")]
    [ActionDescription("Completes the given tween")]
    public class CompleteTween : UFAction
    {
        [In]
        public Tween Tween;

        public override void Execute()
        {
            Tween.Complete();
        }
    }
}