using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Initialize DO Tween")]
    [ActionDescription("Allows you to initialize DO Tween explicitly")]
    public class InitializeDOTween : UFAction
    {
        [In]
        public bool RecycleAllByDefault = true;

        [In]
        public bool UseSafeMode = true;

        [In]
        public LogBehaviour LogBehaviour;

        [In]
        public int ExpectedMaximumConcurrentTweens = 100 ;

        [In]
        public int ExpectedMaximumConcurrentSequences = 10;
        
        public override void Execute()
        {
            DG.Tweening.DOTween.Init(RecycleAllByDefault, UseSafeMode, LogBehaviour)
                .SetCapacity(ExpectedMaximumConcurrentTweens, ExpectedMaximumConcurrentSequences);
        }
    }
}