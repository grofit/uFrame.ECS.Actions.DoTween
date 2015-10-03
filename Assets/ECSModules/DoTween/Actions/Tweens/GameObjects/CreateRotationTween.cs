using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Rotation Tween")]
    [ActionDescription("Creates a rotation tween for configuration or use")]
    public class CreateRotationTween : UFAction
    {
        [In]
        public Vector3 DestinationRotation;
        
        [In]
        public float Duration;

        [In]
        public RotateMode RotateMode;

        [Out] 
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var tweener = EntityView.transform.DORotate(DestinationRotation, Duration, RotateMode);
            tweener.Pause();
            
            CreatedTween = tweener;
        }
    }
}