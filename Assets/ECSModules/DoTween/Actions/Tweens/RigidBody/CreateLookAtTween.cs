using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.RigidBody
{
    [uFrameCategory("DOTween", "Tweens", "Rigidbody")]
    [ActionTitle("Create Look At Tween")]
    [ActionDescription("Creates a rotation tween for configuration or use")]
    public class CreateLookAtTween : UFAction
    {
        [In]
        public Vector3 LookAt;

        [In]
        public float Duration;

        [In]
        public AxisConstraint AxisConstraint;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var rigidbody = EntityView.GetComponent<Rigidbody>();
            var tweener = rigidbody.DOLookAt(LookAt, Duration, AxisConstraint);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}