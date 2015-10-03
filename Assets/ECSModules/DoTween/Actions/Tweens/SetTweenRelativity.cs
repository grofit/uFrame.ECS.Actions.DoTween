using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Set Tween Delay")]
    [ActionDescription("Sets the end point of a given tween to be relative (start + end) or absolute (end)")]
    public class SetTweenRelativity : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public bool IsRelative;
        
        public override void Execute()
        {
            Tween.SetRelative(IsRelative);
        }
    }
}