using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Set Sequence Loop Type")]
    [ActionDescription("Sets the loop type of the given sequence")]
    public class SetSequenceLoopType : UFAction
    {
        [In]
        public Sequence Sequence;

        [In]
        public int Loops;

        [In]
        public LoopType LoopType;

        public override void Execute()
        {
            Sequence.SetLoops(Loops, LoopType);
        }
    }
}