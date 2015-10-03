using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Material Float Tween")]
    [ActionDescription("Creates a float tween for configuration or use")]
    public class CreateMaterialFloatTween : UFAction
    {
        [In]
        public float Value;

        [In]
        public string PropertyName;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var renderer = EntityView.GetComponent<Renderer>();
            var tweener = renderer.material.DOFloat(Value, PropertyName, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}