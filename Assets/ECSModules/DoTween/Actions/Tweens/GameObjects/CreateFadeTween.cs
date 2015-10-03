using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Fade Tween")]
    [ActionDescription("Creates a fade tween for configuration or use")]
    public class CreateFadeTween : UFAction
    {
        [In]
        public float Opacity;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var renderer = EntityView.GetComponent<Renderer>();
            var tweener = renderer.material.DOFade(Opacity, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}