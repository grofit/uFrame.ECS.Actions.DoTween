
using System;
using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.CInput
{
    [uFrameCategory("DOTween")]
    [ActionTitle("Is Sequnece Playing")]
    [ActionDescription("Checks to see the if the sequence is playing")]
    public class IsSequencePlaying : UFAction
    {
        [In]
        public Sequence Sequence;

        [Out] public Action True;
        [Out] public Action False;

        public override void Execute()
        {
            if(Sequence.IsPlaying())
            { True(); }
            else
            { False(); }
        }
    }
}