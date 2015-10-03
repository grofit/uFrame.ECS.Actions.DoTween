using System.Text;
using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Append Tween")]
    [ActionDescription("Append a tween to a sequence")]
    public class AppendTween : UFAction
    {
        [In]
        public Sequence Sequence;

        [In] 
        public Tween Tween;

        public override void Execute()
        {
            Sequence.Append(Tween);
        }
    }
}