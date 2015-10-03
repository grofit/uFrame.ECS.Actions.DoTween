using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Set Tween Loop Type")]
    [ActionDescription("Sets the loop type of the given tween")]
    public class SetTweenLoopType : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public int Loops;

        [In]
        public LoopType LoopType;
        
        public override void Execute()
        {
            Tween.SetLoops(Loops, LoopType);
        }
    }
}