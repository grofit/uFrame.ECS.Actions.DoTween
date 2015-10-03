using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.RigidBody
{
    [uFrameCategory("DOTween", "Tweens", "Rigidbody")]
    [ActionTitle("Create Movement To Position Tween")]
    [ActionDescription("Creates a movement tween for configuration or use")]
    public class CreateMovementTween : UFAction
    {
        [In]
        public Vector3 Destination;

        [In]
        public float Duration;

        [In]
        public bool UseSnapping;

        [Out] 
        public Tween CreatedTween;

        public override void Execute()
        {
            var rigidbody = EntityView.GetComponent<Rigidbody>();
            var tweener = rigidbody.DOMove(Destination, Duration, UseSnapping);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}