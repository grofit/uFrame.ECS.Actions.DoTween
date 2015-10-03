using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.Lights
{
    [uFrameCategory("DOTween", "Tweens", "Lights")]
    [ActionTitle("Create Shadow Strength Tween")]
    [ActionDescription("Creates an intensity tween for configuration or use")]
    public class CreateShadowStrengthTween : UFAction
    {
        [In]
        public float ShadowStrength;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var light = EntityView.GetComponent<Light>();
            var tweener = light.DOShadowStrength(ShadowStrength, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}