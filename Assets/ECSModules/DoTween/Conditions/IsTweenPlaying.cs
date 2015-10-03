
using System;
using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.CInput
{
    [uFrameCategory("DOTween")]
    [ActionTitle("Is Tween Playing")]
    [ActionDescription("Checks to see the if the tween is playing")]
    public class IsTweenPlaying : UFAction
    {
        [In]
        public Tween Tween;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if (Tween.IsPlaying())
            { True(); }
            else
            { False(); }
        }
    }
}