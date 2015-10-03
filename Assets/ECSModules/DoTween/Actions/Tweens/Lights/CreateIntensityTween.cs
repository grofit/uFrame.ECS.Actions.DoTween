using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.Lights
{
    [uFrameCategory("DOTween", "Tweens", "Lights")]
    [ActionTitle("Create Intensity Tween")]
    [ActionDescription("Creates an intensity tween for configuration or use")]
    public class CreateIntensityTween : UFAction
    {
        [In]
        public float Intensity;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var light = EntityView.GetComponent<Light>();
            var tweener = light.DOIntensity(Intensity, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}