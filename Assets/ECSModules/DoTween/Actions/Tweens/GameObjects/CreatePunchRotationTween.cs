using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Punch Rotation Tween")]
    [ActionDescription("Creates a punch rotation tween for configuration or use")]
    public class CreatePunchRotationTween : UFAction
    {
        [In]
        public Vector3 PunchRotation;

        [In]
        public float Duration;

        [In]
        public int Vibration = 10;

        [In]
        public float Elasticity = 1.0f;

        [Out]
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var tweener = EntityView.transform.DOPunchRotation(PunchRotation, Duration, Vibration, Elasticity);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}