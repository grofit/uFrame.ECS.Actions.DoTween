using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Complete Sequences")]
    [ActionDescription("Completes a given sequence")]
    public class CompleteSequence : UFAction
    {
        [In]
        [Out]
        public Sequence Sequence;

        public override void Execute()
        {
            Sequence.PlayBackwards();
        }
    }
}