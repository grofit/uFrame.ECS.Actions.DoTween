using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Play Sequence Backwards")]
    [ActionDescription("Plays a given sequence Backwards")]
    
    public class PlaySequenceBackwards : UFAction
    {
        [In]
        public Sequence Sequence;

        public override void Execute()
        {
            Sequence.PlayBackwards();
        }
    }
}