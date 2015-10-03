using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Prepend Tween")]
    [ActionDescription("Prepend a tween to a sequence")]
    public class PrependTween : UFAction
    {
        [In]
        public Sequence Sequence;

        [In]
        public Tween Tween;

        public override void Execute()
        {
            Sequence.Prepend(Tween);
        }
    }
}