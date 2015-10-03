using System.Collections.Generic;
using System.Linq;
using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.GameObjects
{
    [uFrameCategory("DOTween", "Tweens", "GameObjects")]
    [ActionTitle("Create Path Tween")]
    [ActionDescription("Creates a path tween for configuration or use")]
    public class CreatePathTween : UFAction
    {
        [In]
        public IEnumerable<Vector3> VectorPath;
        
        [In]
        public float Duration;

        [In]
        public PathType PathType = PathType.Linear;

        [In]
        public PathMode PathMode = PathMode.Full3D; 

        [In]
        public int Resolution = 10;

        [Out] 
        public Tween CreatedTween;

        public override void Execute()
        {
            var tweener = EntityView.transform.DOPath(VectorPath.ToArray(), Duration, PathType, PathMode, Resolution);
            tweener.Pause();
            CreatedTween = tweener;
        }
    }
}