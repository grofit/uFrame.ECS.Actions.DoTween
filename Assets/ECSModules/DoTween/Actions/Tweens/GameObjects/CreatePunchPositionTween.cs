using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Punch Position Tween")]
    [ActionDescription("Creates a punch position tween for configuration or use")]
    public class CreatePunchPositionTween : UFAction
    {
        [In]
        public Vector3 PunchVector;

        [In]
        public float Duration;

        [In]
        public int Vibration = 10;

        [In]
        public float Elasticity = 1.0f;

        [In]
        public bool UseSnapping;

        [Out]
        public Tween CreatedTween;
        
        public override void Execute()
        {
            var tweener = EntityView.transform.DOPunchPosition(PunchVector, Duration, Vibration, Elasticity, UseSnapping);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}