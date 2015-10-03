using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Prepend Interval")]
    [ActionDescription("Prepend an interval to a sequence")]
    public class PrependInterval : UFAction
    {
        [In]
        public Sequence Sequence;

        [In]
        public float Interval;


        public override void Execute()
        {
            Sequence.PrependInterval(Interval);
        }
    }
}