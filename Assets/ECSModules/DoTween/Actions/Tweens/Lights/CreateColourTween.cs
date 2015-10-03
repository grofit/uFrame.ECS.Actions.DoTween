using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.Lights
{
    [uFrameCategory("DOTween", "Tweens", "Lights")]
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
            var light = EntityView.GetComponent<Light>();
            var tweener = light.DOColor(NewColour, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}