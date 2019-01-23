using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateableTraps : MonoBehaviour
{
    
    public float PlayerJumoForceX;
    public float RotateAngle;
    public float RotateDuration;
    public float MoveDuration;

    public int CollisionCount;

    player playerScript;

    public GameObject PathTarget;

    public enum TrapType { None, WithPath};
    public TrapType trapType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D  rb = collision.gameObject.GetComponent<Rigidbody2D>(); 
        if (collision.gameObject.tag == "Player")
        {
            playerScript = collision.gameObject.GetComponent<player>();
            playerScript.JumoForceX = PlayerJumoForceX;
            collision.gameObject.transform.parent = gameObject.transform;
            if (CollisionCount > 0) { 



               if (trapType == TrapType.None)
               {

                collision.gameObject.transform.parent = gameObject.transform;
                Sequence mySequence = DOTween.Sequence();
             
                mySequence.Append(transform.DORotate(new Vector3(0, 0, RotateAngle), RotateDuration).SetEase(Ease.Linear));
                    CollisionCount--;
               }
               else
               {
                   // rb.isKinematic = true;
                    Sequence mySequence = DOTween.Sequence();
                    mySequence.Append(transform.DOMove(PathTarget.transform.position, MoveDuration).SetEase(Ease.Linear));
                    mySequence.Append(transform.DORotate(new Vector3(0, 0, RotateAngle), RotateDuration).SetEase(Ease.Linear));
                    //gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                    CollisionCount--;

                }

            }












        }
    }
}
