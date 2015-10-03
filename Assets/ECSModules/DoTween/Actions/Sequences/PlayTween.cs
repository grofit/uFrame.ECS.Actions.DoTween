using System;
using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Play Tween")]
    [ActionDescription("Plays a given Sequence")]
    public class PlaySequence : UFAction
    {
        [In] 
        public Sequence Sequence;

        [In]
        public bool WaitUntilFinished;

        [Out]
        public Action Finished;

        public override void Execute()
        {
            if (WaitUntilFinished)
            {
                Sequence.OnComplete(() => Finished());
            }

            Sequence.Play();

            if (!WaitUntilFinished)
            {
                Finished();
            }
        }
    }
}