using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.Materials
{
    [uFrameCategory("DOTween", "Tweens", "Materials")]
    [ActionTitle("Create Colour Property Tween")]
    [ActionDescription("Creates a colour tween for configuration or use")]
    public class CreateColourPropertyTween : UFAction
    {
        [In] 
        public Material Material;

        [In]
        public Color NewColour;

        [In]
        public string PropertyName;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var tweener = Material.DOColor(NewColour, PropertyName, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}