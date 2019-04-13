using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game_Manager : MonoBehaviour
{
    GameObject Player;
    GameObject StartStage;

    private void Start()
    {
        SetPlayerPos();
        Time.timeScale = 0;
    }
    public void SetPlayerPos()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        StartStage = GameObject.FindGameObjectWithTag("StartStage");
        Player.transform.position = StartStage.transform.position + new Vector3(0, 0.2f, 0);
    }
    
}
