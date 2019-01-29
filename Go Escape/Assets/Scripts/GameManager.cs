using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Wolves.Tools.Collections;

public class GameManager : MonoBehaviour
{
    GameObject Player;
    GameObject StartStage;
    GameObject WinStage;
    [SerializeField]
    public SerializableDictionaryBase<int, GameObject> Levels;
   
    // Start is called before the first frame update

    void Start()
    {
       
        //Instantiate(Levels[0]);
        Player = GameObject.FindGameObjectWithTag("Player");
        StartStage = GameObject.FindGameObjectWithTag("StartStage");
        WinStage = GameObject.FindGameObjectWithTag("WinStage");
        SetPlayerPos();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Player.GetComponent<player>().finishGame == true)
        //{
        //    WinGame();
        //}
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void SetPlayerPos()
    {
        Vector3 NewPlayerPos = StartStage.transform.position + new Vector3(0, 0.2f,0);
        Player.transform.position = NewPlayerPos;
        Debug.Log("SetPlayerPos");
    }
    public void WinGame()
    {
        SceneManager.LoadScene(0);
    }
}
