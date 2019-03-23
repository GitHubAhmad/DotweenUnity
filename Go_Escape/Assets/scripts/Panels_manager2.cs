using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Panels_manager2 : MonoBehaviour
{

    public GameObject Level_Parts;
    public RectTransform Level_Parts_Home;
    public Vector3 Initial_Level_Parts;
    public float Home_new_Pos;

    

    public GameObject All_Levels;
    public RectTransform[] All_Levels_Objects;
    public RectTransform Back_bottom;
    public float Back_new_Pos;
    public Vector3 Initial_Scale_All_Levels;
    public Vector3 All_Levels_New_Scals;
    public Vector3 Back_initial_pos;
    public float Duration;


    public void Swithcseans()
    {
        SceneManager.LoadScene(0);  
    }

    public void Level_Parts_Tweens()
    {
        Level_Parts.SetActive(true);
        All_Levels.SetActive(false);
        // domove to home bottom .
        Level_Parts_Home.transform.DOLocalMoveX(Home_new_Pos, Duration);
        
    }


    public void All_Levels_Tweens()
    {
        Level_Parts.SetActive(false);
        All_Levels.SetActive(true);
        //domove to backbottom .
        Back_bottom.transform.DOLocalMoveX(Back_new_Pos, Duration);

        //doscale to levels.
        for (int i = 0; i < All_Levels_Objects.Length; i++)
        {
            All_Levels_Objects[i].transform.DOScale(All_Levels_New_Scals, Duration*1/2);    
        }
        Debug.Log("Hi ");
    }


    public void Set_Pos_Level_Parts_Tweens()
    {
        DOTween.KillAll();
        Level_Parts_Home.transform.localPosition = Initial_Level_Parts;
    }










    public void Set_Pos_All_Levels_Tweens()
    {
        DOTween.KillAll();
        Back_bottom.transform.localPosition = Back_initial_pos;
        for (int i = 0; i < All_Levels_Objects.Length; i++)
        {
            All_Levels_Objects[i].transform.localScale = Initial_Scale_All_Levels;
            Debug.Log(i);
        }
    }









    // Start is called before the first frame update
    void Start()
    {
        Level_Parts_Tweens();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
