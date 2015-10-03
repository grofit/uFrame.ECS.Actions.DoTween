using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens.TrailRenderer
{
    [uFrameCategory("DOTween", "Tweens", "TrailRenderer")]
    [ActionTitle("Create Time Tween")]
    [ActionDescription("Creates a time tween for configuration or use")]
    public class CreateTimeTween : UFAction
    {
        [In]
        public float EndValue;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;
       
        public override void Execute()
        {
            var trailRenderer = EntityView.GetComponent<UnityEngine.TrailRenderer>();
            var tweener = trailRenderer.DOTime(EndValue, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}