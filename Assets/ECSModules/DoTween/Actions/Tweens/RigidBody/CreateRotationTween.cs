using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.RigidBody
{
    [uFrameCategory("DOTween", "Tweens", "Rigidbody")]
    [ActionTitle("Create Rotation Tween")]
    [ActionDescription("Creates a rotation tween for configuration or use")]
    public class CreateRotationTween : UFAction
    {
        [In]
        public Vector3 Rotation;

        [In]
        public float Duration;

        [In]
        public RotateMode RotateMode;

        [Out] 
        public Tween CreatedTween;

        public override void Execute()
        {
            var rigidbody = EntityView.GetComponent<Rigidbody>();
            var tweener = rigidbody.DORotate(Rotation, Duration, RotateMode);
            tweener.Pause();
            
            CreatedTween = tweener;
        }
    }
}