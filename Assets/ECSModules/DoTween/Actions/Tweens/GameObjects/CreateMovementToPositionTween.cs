using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Movement To Position Tween")]
    [ActionDescription("Creates a movement tween for configuration or use")]
    public class CreateMovementToPositionTween : UFAction
    {
        [In]
        public Vector3 Destination;

        [In]
        public float Duration;
        public bool UseSnapping;

        [Out] 
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var tweener = EntityView.transform.DOMove(Destination, Duration, UseSnapping);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}