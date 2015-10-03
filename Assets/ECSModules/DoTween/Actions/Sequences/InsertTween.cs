using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Insert Tween")]
    [ActionDescription("Insert a tween at a given time position in a sequence")]
    public class InsertTween : UFAction
    {
        [In]
        public Sequence Sequence;

        [In]
        public Tween Tween;

        [In] 
        public float TimePosition;
        
        public override void Execute()
        {
            Sequence.Insert(TimePosition, Tween);
        }
    }
}