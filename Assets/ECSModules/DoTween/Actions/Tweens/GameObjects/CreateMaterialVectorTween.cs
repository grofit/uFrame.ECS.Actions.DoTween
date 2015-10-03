using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Material Vector Tween")]
    [ActionDescription("Creates a vector tween for configuration or use")]
    public class CreateMaterialVectorTween : UFAction
    {
        [In]
        public Vector3 Value;

        [In]
        public string PropertyName;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;
        

        public override void Execute()
        {
            var renderer = EntityView.GetComponent<Renderer>();
            var tweener = renderer.material.DOVector(Value, PropertyName, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}