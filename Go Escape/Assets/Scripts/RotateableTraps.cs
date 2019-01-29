using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

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

    public static Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb = collision.gameObject.GetComponent<Rigidbody2D>();
        if (collision.gameObject.tag == "Player")
        {
            playerScript = collision.gameObject.GetComponent<player>();
            playerScript.JumoForceX = PlayerJumoForceX;
            collision.gameObject.transform.parent = gameObject.transform;          
            Debug.Log(rb.gravityScale);
         
               if (trapType == TrapType.None)
               {
                   collision.gameObject.transform.parent = gameObject.transform;
                   Sequence mySequence = DOTween.Sequence();         
                   mySequence.Append(transform.DORotate(new Vector3(0, 0, RotateAngle), RotateDuration).SetEase(Ease.Linear));
                   CollisionCount--;
               }
            
           
               else
               {
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                  if (CollisionCount > 0)
                  {
                      Sequence mySequence = DOTween.Sequence();
                      mySequence.Append(transform.DOMove(PathTarget.transform.position, MoveDuration).SetEase(Ease.Linear)).AppendCallback(dontFreez);
                      mySequence.Append(transform.DORotate(new Vector3(0, 0, RotateAngle), RotateDuration).SetEase(Ease.Linear));
                      CollisionCount--;
                  }
                    
               }
            
        }
    }

   

    public void dontFreez()
    {
        rb.constraints = RigidbodyConstraints2D.None;
    }
   
    
  
}
