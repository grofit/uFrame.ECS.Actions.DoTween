using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Pause Sequence")]
    [ActionDescription("Pauses a given Sequence")]
    public class PauseSequence : UFAction
    {
        [In]
        public Sequence Sequence;

        public override void Execute()
        {
            Sequence.Pause();
        }
    }
}