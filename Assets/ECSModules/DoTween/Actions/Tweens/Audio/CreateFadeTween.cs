using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.Audio
{
    [uFrameCategory("DOTween", "Tweens", "Audio")]
    [ActionTitle("Create Fade Tween")]
    [ActionDescription("Creates a fade tween for configuration or use")]
    public class CreateFadeTween : UFAction
    {
        [In]
        public float Fade;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var audioSource = EntityView.GetComponent<AudioSource>();
            var tweener = audioSource.DOFade(Fade, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}