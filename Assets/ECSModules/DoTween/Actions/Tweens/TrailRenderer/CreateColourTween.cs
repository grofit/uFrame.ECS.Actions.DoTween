using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens.TrailRenderer
{
    [uFrameCategory("DOTween", "Tweens", "TrailRenderer")]
    [ActionTitle("Create Resize Tween")]
    [ActionDescription("Creates a colour tween for configuration or use")]
    public class CreateResizeTween : UFAction
    {
        [In]
        public float StartSize;

        [In]
        public float EndSize;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var trailRenderer = EntityView.GetComponent<UnityEngine.TrailRenderer>();
            var tweener = trailRenderer.DOResize(StartSize, EndSize, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}