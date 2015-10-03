using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Play Sequence Forward")]
    [ActionDescription("Plays a given sequence forwards")]
    public class PlaySequenceForward : UFAction
    {
        [In]
        public Sequence Sequence;

        public override void Execute()
        {
            Sequence.PlayForward();
        }
    }
}