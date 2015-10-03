using System.Text;

using DG.Tweening;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.DOTween.Sequences
{
    [uFrameCategory("DOTween", "Sequences")]
    [ActionTitle("Create Sequences")]
    [ActionDescription("Creates a sequence for configuration or use")]
    public class CreateSequence : UFAction
    {
        [Out]
        public Sequence CreatedSequence;
        
        public override void Execute()
        {
            var sequence = DG.Tweening.DOTween.Sequence();
            CreatedSequence = sequence;
            sequence.Pause();
        }
    }
}