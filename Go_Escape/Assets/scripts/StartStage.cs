using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartStage : MonoBehaviour
{
    GameObject child1, child2;
    // Start is called before the first frame update
    void Start()
    {
        child1 = transform.GetChild(0).gameObject;
        child2 = transform.GetChild(1).gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartEffect()
    {
        child1.transform.DORotate(new Vector3(0, 0, 90), 0.3f).SetEase(Ease.Linear);
        child2.transform.DORotate(new Vector3(0, 0, -90), 0.3f).SetEase(Ease.Linear);

    }
}
