using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;


namespace ECSModules.DOTween.Tweens
{
    [uFrameCategory("DOTween", "Tweens")]
    [ActionTitle("Toggle Tween Pause")]
    [ActionDescription("Toggles pause on a tween")]
    public class PauseToggleTween : UFAction
    {
        [In]
        public Tween Tween;


        public override void Execute()
        {
            Tween.TogglePause();
        }
    }
}