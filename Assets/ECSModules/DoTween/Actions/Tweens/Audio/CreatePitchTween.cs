using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.Audio
{
    [uFrameCategory("DOTween", "Tweens", "Audio")]
    [ActionTitle("Create Pitch Tween")]
    [ActionDescription("Creates a pitch tween for configuration or use")]
    public class CreatePitchTween : UFAction
    {
        [In]
        public float Pitch;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var audioSource = EntityView.GetComponent<AudioSource>();
            var tweener = audioSource.DOPitch(Pitch, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}