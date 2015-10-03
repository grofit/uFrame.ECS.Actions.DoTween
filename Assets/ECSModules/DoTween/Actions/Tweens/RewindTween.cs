using System;
using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Rewind Tween")]
    [ActionDescription("Rewinds a given tween")]
    public class RewindTween : UFAction
    {
        [In]
        public Tween Tween;

        [In]
        public bool IncludeDelay;

        [In]
        public bool WaitUntilFinished;

        [Out]
        public Action Rewound;

        public override void Execute()
        {
            if (WaitUntilFinished)
            {
                Tween.OnComplete(() => Rewound());
            }

            Tween.Rewind(IncludeDelay);

            if (!WaitUntilFinished)
            {
                Rewound();
            }
        }
    }
}