using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Look At Transform Tween")]
    [ActionDescription("Creates a look at tween for configuration or use")]
    public class CreateLookAtTransformTween : UFAction
    {
        [In]
        public Transform LookAtObject;

        [In]
        public float Duration;
        public AxisConstraint AxisConstraint;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var tweener = EntityView.transform.DOLookAt(LookAtObject.position, Duration, AxisConstraint);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}