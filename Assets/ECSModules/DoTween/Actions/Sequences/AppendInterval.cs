using System.Text;
using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Append Interval")]
    [ActionDescription("Append an interval to a sequence")]
    public class AppendInterval : UFAction
    {
        [In]
        public Sequence Sequence;

        [In]
        public float Interval;

        public override void Execute()
        {
            Sequence.AppendInterval(Interval);
        }
    }
}