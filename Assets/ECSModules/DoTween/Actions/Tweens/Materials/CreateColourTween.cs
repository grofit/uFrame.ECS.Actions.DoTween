using System.Text;

using DG.Tweening;
using DG.Tweening.Core;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.Materials
{
    [uFrameCategory("DOTween", "Tweens", "Materials")]
    [ActionTitle("Create Colour Tween")]
    [ActionDescription("Creates a colour tween for configuration or use")]
    public class CreateColourTween : UFAction
    {
        [In]
        public Material Material;

        [In]
        public Color NewColour;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var tweener = Material.DOColor(NewColour, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}