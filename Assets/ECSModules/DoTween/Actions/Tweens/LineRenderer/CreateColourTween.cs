using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;


namespace ECSModules.DOTween.Tweens.LineRenderer
{
    [uFrameCategory("DOTween", "Tweens", "LineRenderer")]
    [ActionTitle("Create Colour Tween")]
    [ActionDescription("Creates a colour tween for configuration or use")]
    public class CreateColourTween : UFAction
    {
        [In]
        public Color StartColour;

        [In]
        public Color EndColour;

        [In]
        public float Duration;

        [Out]
        public Tween CreatedTween;

        public override void Execute()
        {
            var startColour = new Color2(StartColour, StartColour);
            var endColour = new Color2(EndColour, EndColour);
            var lineRenderer = EntityView.GetComponent<UnityEngine.LineRenderer>();
            var tweener = lineRenderer.DOColor(startColour, endColour, Duration);
            tweener.Pause();

            CreatedTween = tweener;
        }
    }
}