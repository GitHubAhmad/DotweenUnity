using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ResPawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResPawn()
    {
        //transform.position = Vector2.zero;
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * 5;
    }
}
