using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Movement To Object Tween")]
    [ActionDescription("Creates a movement tween for configuration or use")]
    
    public class CreateMovementToObjectTween : UFAction
    {
        [In]
        public Transform DestinationObject;

        [In]
        public float Duration;

        [In]
        public bool UseSnapping;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var tweener = EntityView.transform.DOMove(DestinationObject.transform.position, Duration, UseSnapping);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}