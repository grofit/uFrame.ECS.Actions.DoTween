using System.Text;
using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Kill Tweens")]
    [ActionDescription("Kills all tweens related to the object")]
    public class KillTweens : UFAction
    {
        public bool ShouldComplete;
        
        public override void Execute()
        {
            EntityView.transform.DOKill(ShouldComplete);
        }
    }
}