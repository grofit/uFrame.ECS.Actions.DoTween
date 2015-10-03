using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Set Tween Delay")]
    [ActionDescription("Sets the delay of a given tween")]
    public class SetTweenDelay : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public float Delay;
        
        public override void Execute()
        {
            Tween.SetDelay(Delay);
        }
    }
}