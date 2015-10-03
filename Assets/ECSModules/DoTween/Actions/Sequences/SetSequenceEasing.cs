using System.Text;
using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Set Sequence Easing")]
    [ActionDescription("Sets the easing type of the given sequence")]
    public class SetSequenceEasing: UFAction
    {
        [In]
        public Sequence Sequence;

        [In]
        public float EaseAmplitudeOrOvershoot;

        [In]
        public float EasePeriod;

        public override void Execute()
        {
            Sequence.easeOvershootOrAmplitude = EaseAmplitudeOrOvershoot;
            Sequence.easePeriod = EasePeriod;
        }
    }
}