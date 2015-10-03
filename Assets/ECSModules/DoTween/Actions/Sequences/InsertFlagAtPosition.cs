using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Insert Flag At Position")]
    [ActionDescription("Inserts a callback in the sequence which will set a given flag to true when it occurs")]
    public class InsertFlagAtPosition : UFAction
    {
        [In]
        public Sequence Sequence;

        [In]
        public bool FlagVariable;

        [In]
        public float TimePosition;

        public override void Execute()
        {
            Sequence.InsertCallback(TimePosition, () => { FlagVariable = true; });
        }
    }
}