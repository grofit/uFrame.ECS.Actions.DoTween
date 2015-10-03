using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Set Tween Ease")]
    [ActionDescription("Sets the ease type of a given tween")]
    public class SetTweenEase : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public Ease EaseType = Ease.Linear;
        
        public override void Execute()
        {
            Tween.SetEase(EaseType);
        }
    }
}