using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Toggle Sequence Pause")]
    [ActionDescription("Toggles pause for a given Sequence")]
    public class ToggleSequencePause : UFAction
    {
        [In]
        public Sequence Sequence;

        public override void Execute()
        {
            Sequence.TogglePause();
        }
    }
}