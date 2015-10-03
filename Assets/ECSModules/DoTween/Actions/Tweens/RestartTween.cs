using System;
using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Restart Tween")]
    [ActionDescription("Restarts a given tween")]
    public class RestartTween : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public bool IncludeDelay;

        [In]
        public bool WaitUntilFinished;

        [Out]
        public Action Restarted;
        
        public override void Execute()
        {
            if (WaitUntilFinished)
            {
                Tween.OnComplete(() => Restarted());
            }

            Tween.Restart(IncludeDelay);

            if (!WaitUntilFinished)
            {
                Restarted();
            }
        }
    }
}