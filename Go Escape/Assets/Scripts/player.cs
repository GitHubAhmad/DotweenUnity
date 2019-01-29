using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class player : MonoBehaviour
{
    public float JumoForceX;
    public float JumpForceY;
    public float GravetyScalRealValue;
    Rigidbody2D rb;

    

    public GameObject StartStage;
    public GameObject c1;
    public GameObject c2;

    public bool finishGame = false;
    public bool IsGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody2D>();
        StartStage = GameObject.FindGameObjectWithTag("StartStage");
        c1 = StartStage.transform.GetChild(0).gameObject;
        c2 = StartStage.transform.GetChild(1).gameObject;

       

    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.parent = null;
           
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                GetStarted();
            }
            else
            {
                if (IsGrounded)
                {
                    rb.constraints = RigidbodyConstraints2D.None;
                    rb.velocity = new Vector2(JumoForceX, JumpForceY);
                }               
            }
        }
       
    }
    public void GetStarted()
    {
        c1.transform.DOLocalRotate(new Vector3(0, 0, -90), 0.3f).SetEase(Ease.Linear);
        c2.transform.DOLocalRotate(new Vector3(0, 0, 90), 0.3f).SetEase(Ease.Linear);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsGrounded = true;
        if (collision.gameObject.tag == "Trap")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag== "WinStage")
        {
            finishGame = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        IsGrounded = false;
    }

}
