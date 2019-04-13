using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float JumoForceX;
    public float JumpForceY;

    Rigidbody2D rb;
    GameObject StartStage;
    StartStage StartStageScript;
   
    public bool FinishGame;
    public bool IsGrounded;
    // Start is called before the first frame update
    void Start()
    {
        StartStage = GameObject.FindGameObjectWithTag("StartStage");
        StartStageScript = StartStage.GetComponent<StartStage>();
        rb = GetComponent<Rigidbody2D>();
        //StartStage = GameObject.FindGameObjectWithTag("StartStage");
        //c1 = StartStage.transform.GetChild(0).gameObject;
        //c2 = StartStage.transform.GetChild(1).gameObject;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                StartStageScript.StartEffect();
            }
            else
            {
                if (IsGrounded)
                {
                    rb.constraints = RigidbodyConstraints2D.None;
                    gameObject.transform.parent = null;
                    rb.velocity = new Vector2(JumoForceX, JumpForceY);
                  
                }
            }


        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    GetStarted();
        //}
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsGrounded = true;
        if (collision.gameObject.tag == "Trap")
        {
            Destroy(gameObject);
        }
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        IsGrounded = false;
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WinStage")
        {
            FinishGame = true;
            transform.parent = null;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameCollider")
        {
            SceneManager.LoadScene(0);
        }
    }
}
