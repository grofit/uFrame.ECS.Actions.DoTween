using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Colour Tween")]
    [ActionDescription("Creates a colour tween for configuration or use")]
    public class CreateColourTween : UFAction
    {
        [In]
        public Color NewColour;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var renderer = EntityView.GetComponent<Renderer>();
            var tweener = renderer.material.DOColor(NewColour, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}