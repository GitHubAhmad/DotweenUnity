using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remake_Script : MonoBehaviour
{


    Transform[] Remaked_objects;

    public GameObject mypanel;

    private void Start()
    {

        Remake_My_Game();
        System.Console.WriteLine(mypanel.transform.childCount);
    }
    public void Remake_My_Game()
    {
        for (int i = 0; i < mypanel.transform.childCount; i++)
        {
            Remaked_objects[i] = mypanel.transform.GetChild(i).GetComponent<Transform>();
        }
        
    }
    private void OnDisable()
    {
        
        for (int i = 0; i < mypanel.transform.childCount; i++)
        {
            mypanel.transform.GetChild(i).position = Remaked_objects[i].position;
            mypanel.transform.GetChild(i).rotation = Remaked_objects[i].rotation;
            mypanel.transform.GetChild(i).localScale = Remaked_objects[i].localScale;
        }
    }
    //private void OnEnable()
    //{
    //    Debug.Log("OnEnable");
    //    for (int i = 0; i < gameObject.transform.childCount; i++)
    //    {
    //        gameObject.transform.GetChild(i).position = Remaked_objects[i].position;
    //        gameObject.transform.GetChild(i).rotation = Remaked_objects[i].rotation;
    //        gameObject.transform.GetChild(i).localScale = Remaked_objects[i].localScale;
    //    }
    //}

}
