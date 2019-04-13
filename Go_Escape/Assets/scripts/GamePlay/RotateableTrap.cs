using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class RotateableTrap  : MonoBehaviour
{

    public float PlayerJumoForceX;
    public float RotateAngle;
    public float RotateDuration;
    public float MoveDuration;
    //public float Friction;
    public int CollisionCount;

    player playerScript;
    Rigidbody2D PlayersRigidbody2D;
    //PhysicsMaterial2D PhysicsMaterial2D; 
    public GameObject Target;




    public enum TrapType { Joint_In_Edges, Joint_In_Middle, With_Target ,None};
    public TrapType trapType;


    
    // Start is called before the first frame update



    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            SceneManager.LoadScene(2);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayersRigidbody2D = collision.gameObject.GetComponent<Rigidbody2D>();
        if (collision.gameObject.tag == "Player")
        {

            //PhysicsMaterial2D =collision.gameObject.GetComponent<Collider2D>().sharedMaterial;
            //PhysicsMaterial2D.friction = Friction;
            playerScript = collision.gameObject.GetComponent<player>();
            playerScript.JumoForceX = PlayerJumoForceX;
            collision.gameObject.transform.parent = gameObject.transform;
            if (trapType == TrapType.Joint_In_Edges)
            {

                collision.gameObject.transform.parent = gameObject.transform;
                Sequence mySequence = DOTween.Sequence();

                mySequence.Append(transform.DORotate(new Vector3(0, 0, RotateAngle), RotateDuration).SetEase(Ease.OutSine));
                CollisionCount--;

            }
            else if (trapType == TrapType.Joint_In_Middle)
            {

                collision.gameObject.transform.parent = gameObject.transform;
                Sequence mySequence = DOTween.Sequence();

                mySequence.Append(transform.DORotate(new Vector3(0, 0, RotateAngle), RotateDuration).SetEase(Ease.Linear));
                CollisionCount--;

            }
            else if (trapType == TrapType.None)
            {               
            }
            else
            {
                PlayersRigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionX;
                if (CollisionCount > 0)
                {
                   Sequence mySequence = DOTween.Sequence();
                   mySequence.Append(transform.DOMove(Target.transform.position, MoveDuration).SetEase(Ease.Linear)).AppendCallback(Free);
                   mySequence.Append(transform.DORotate(new Vector3(0, 0, RotateAngle), RotateDuration).SetEase(Ease.Linear));

                   CollisionCount--;
                }
            }            
        }
    }
    public void Free()
    {
        PlayersRigidbody2D.constraints = RigidbodyConstraints2D.None;
    }
}