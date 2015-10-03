using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Join Tween")]
    [ActionDescription("Joins a tween in a given sequence")]
    public class JoinTween : UFAction
    {
        [In]
        public Sequence Sequence;

        [In]
        public Tween Tween;

        public override void Execute()
        {
            Sequence.Join(Tween);
        }
    }
}