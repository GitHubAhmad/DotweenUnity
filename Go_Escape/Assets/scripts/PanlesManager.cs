using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PanlesManager : MonoBehaviour
{
    public GameObject Main_menu;
    public GameObject[] Main_Menu_Objects;
    public Vector3[] Initial_Transforms_MainMenu;
    public Vector3[] Initial_Scale_MainMenu;

    public GameObject Info;
    public GameObject Info_Object;
    public Vector3 Initial_Transform;
    public float Info_new_Pos;


     public float Duration;
     public float[] Main_Menu_New_Pos;
     public float Duration2;

     public Vector2[] Main_Menu_New_Scals;


    public Vector3 circle;


    public void Main_Menu_Tweens()
    {
        Main_menu.SetActive(true);
        Info.SetActive(false);
        Main_Menu_Objects[0].transform.DOScale(Main_Menu_New_Scals[0], Duration);
        Main_Menu_Objects[1].transform.DOScale(Main_Menu_New_Scals[1], Duration2);
        Main_Menu_Objects[1].transform.DOMoveX(Main_Menu_New_Pos[4], Duration2).SetEase(Ease.OutExpo);
        Main_Menu_Objects[1].transform.DORotate(circle, Duration2, RotateMode.FastBeyond360);
        Main_Menu_Objects[2].transform.DOScale(Main_Menu_New_Scals[2], Duration);
        Main_Menu_Objects[3].transform.DOMoveX(Main_Menu_New_Pos[0], Duration2);
        Main_Menu_Objects[4].transform.DOMoveY(Main_Menu_New_Pos[1], Duration2 * 1 / 4).SetEase(Ease.OutBack);
        Main_Menu_Objects[5].transform.DOMoveY(Main_Menu_New_Pos[2], Duration2 * 1 / 3).SetEase(Ease.OutBack);
        Main_Menu_Objects[6].transform.DOMoveY(Main_Menu_New_Pos[2], Duration2 * 1 / 2).SetEase(Ease.OutBack);
        Main_Menu_Objects[7].transform.DOMoveY(Main_Menu_New_Pos[3], Duration2 * 1).SetEase(Ease.OutBack);
    }
   
    public void Info_Tweens()
    {
        Main_menu.SetActive(false);
        Info.SetActive(true);
        Info_Object.transform.DOMoveX(Info_new_Pos, Duration2);

    }
    public void Set_Pos_Main_Menu()
    {
        DOTween.KillAll();
        Main_Menu_Objects[1].transform.localPosition = Initial_Transforms_MainMenu[1];//Gamelogo
        Main_Menu_Objects[3].transform.localPosition = Initial_Transforms_MainMenu[2];
        Main_Menu_Objects[4].transform.localPosition = Initial_Transforms_MainMenu[3];
        Main_Menu_Objects[5].transform.localPosition = Initial_Transforms_MainMenu[4];
        Main_Menu_Objects[6].transform.localPosition = Initial_Transforms_MainMenu[5];
        Main_Menu_Objects[7].transform.localPosition = Initial_Transforms_MainMenu[6];


        Main_Menu_Objects[0].transform.localScale = Initial_Scale_MainMenu[0];//rectangle
        Main_Menu_Objects[1].transform.localScale = Initial_Scale_MainMenu[1];//Game logo (pos)
        Main_Menu_Objects[2].transform.localScale = Initial_Scale_MainMenu[2];// Play button
       
       
       


       Main_Menu_Objects[1].transform.localRotation = Quaternion.Euler(Initial_Transforms_MainMenu[0]);//Gamelogo                                       



    }

    public void Set_Pos_Info()
    {
        DOTween.KillAll();
        Info_Object.transform.localPosition = Initial_Transform;
    }


    void Start()
    {
        Main_Menu_Objects[0].transform.DOScale(Main_Menu_New_Scals[0], Duration);
        Main_Menu_Objects[1].transform.DOScale(Main_Menu_New_Scals[1], Duration2);
        Main_Menu_Objects[1].transform.DOMoveX(Main_Menu_New_Pos[4], Duration2).SetEase(Ease.OutExpo);
        Main_Menu_Objects[1].transform.DORotate(circle, Duration2, RotateMode.FastBeyond360);
        Main_Menu_Objects[2].transform.DOScale(Main_Menu_New_Scals[2], Duration);
        Main_Menu_Objects[3].transform.DOMoveX(Main_Menu_New_Pos[0], Duration2);
        Main_Menu_Objects[4].transform.DOMoveY(Main_Menu_New_Pos[1], Duration2 * 1 / 4).SetEase(Ease.OutBack);
        Main_Menu_Objects[5].transform.DOMoveY(Main_Menu_New_Pos[2], Duration2 * 1 / 3).SetEase(Ease.OutBack);
        Main_Menu_Objects[6].transform.DOMoveY(Main_Menu_New_Pos[2], Duration2 * 1 / 2).SetEase(Ease.OutBack);
        Main_Menu_Objects[7].transform.DOMoveY(Main_Menu_New_Pos[3], Duration2 * 1).SetEase(Ease.OutBack);
    }

   
    void Update()
    {
        
    }
}
