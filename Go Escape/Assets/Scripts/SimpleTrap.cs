using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTrap : MonoBehaviour
{
    public float PlayerJumoForceX;
    player playerScript;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerScript = collision.gameObject.GetComponent<player>();
            playerScript.JumoForceX = PlayerJumoForceX;
        }
    }
}
