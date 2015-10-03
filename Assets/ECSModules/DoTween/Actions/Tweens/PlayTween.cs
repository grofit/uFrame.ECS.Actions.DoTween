using System;
using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Play Tween")]
    [ActionDescription("Plays a given tween")]
    public class PlayTween : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public bool WaitUntilFinished;

        [In]
        public Action Playing;
        
        public override void Execute()
        {
            if (WaitUntilFinished)
            {
                Tween.OnComplete(() => Playing());
            }

            Tween.Play();

            if (!WaitUntilFinished)
            {
                Playing();
            }
        }
    }
}