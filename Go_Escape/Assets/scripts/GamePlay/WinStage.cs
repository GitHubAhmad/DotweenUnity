using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WinStage : MonoBehaviour
{
    public SpriteRenderer Tringle1, Tringle2, Tringle3;

   
    void Start()
    {
        StartCoroutine(delay());
        //WinStageEffect();
    }
    IEnumerator delay()
    {
        yield return new WaitForEndOfFrame();
        WinStageEffect();
    }
    
    public void WinStageEffect()
    {
       
            Color initialColor = Tringle1.color;
            Sequence mySequance = DOTween.Sequence();
            mySequance.Append(Tringle1.DOColor(Color.white, 0.1f));
            mySequance.Insert(0.15f, Tringle1.DOColor(initialColor, 0.01f));
            mySequance.Append(Tringle2.DOColor(Color.white, 0.1f));
            mySequance.Insert(0.25f, Tringle2.DOColor(initialColor, 0.01f));
            mySequance.Append(Tringle3.DOColor(Color.white, 0.1f));
            mySequance.Insert(0.25f, Tringle3.DOColor(initialColor, 0.01f));
            mySequance.SetLoops(-1, LoopType.Restart);
             
    }
}
