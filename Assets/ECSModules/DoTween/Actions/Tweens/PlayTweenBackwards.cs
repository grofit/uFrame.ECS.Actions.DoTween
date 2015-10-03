using System;
using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Play Tween Backwards")]
    [ActionDescription("Plays a given tween backwards")]
    
    public class PlayTweenBackwards : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public bool WaitUntilFinished;

        [Out] public Action Playing;
        
        public override void Execute()
        {
            if (WaitUntilFinished)
            {
                Tween.OnComplete(() => Playing());
            }
            
            Tween.PlayBackwards();

            if (!WaitUntilFinished)
            {
                Playing();
            }
        }
    }
}