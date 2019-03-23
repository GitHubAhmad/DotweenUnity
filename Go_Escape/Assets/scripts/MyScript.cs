//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using DG.Tweening;
//using UnityEngine.UI;


//public class MyScript : MonoBehaviour
//{
//    public enum Sound { Sound_On, Sound_Off };
//    public float Duration;
//    public float[] positions;
//    public float Duration2;
//    public Transform[] MyObjects;
//    bool MyBoll = true;
//    public Vector2[] MyPositions;
//    public Vector3 circle;
//    public float pos;
//    public GameObject[] panels;
//    public GameObject[] bottoms;
//    public GameObject test;
//    public Transform[] My_Saved_transforms;

//    List<Transform> MyTransforms = new List<Transform>();


//    List<Vector3> Remaked_objects = new List<Vector3>();


//    List<Tween> Tweeens = new List<Tween>();

//    public void Remake_My_Game()
//    {
//        for (int i = 0; i < gameObject.transform.childCount + 1; i++)
//        {
//            Remaked_objects.Add(new Vector3(gameObject.transform.GetChild(i).position.x, gameObject.transform.GetChild(i).position.y, gameObject.transform.GetChild(i).position.z));
//            Remaked_objects.Add(new Vector3(gameObject.transform.GetChild(i).rotation.x, gameObject.transform.GetChild(i).rotation.y, gameObject.transform.GetChild(i).rotation.z));
//            Remaked_objects.Add(new Vector3(gameObject.transform.GetChild(i).localScale.x, gameObject.transform.GetChild(i).localScale.y, gameObject.transform.GetChild(i).localScale.z));
//            Remaked_objects[i].x = panels[0].transform.GetChild(i).rotation.x;
//            Remaked_objects[i].x = panels[0].transform.GetChild(i).localScale.x;



//            Remaked_objects[i].y = panels[0].transform.GetChild(i).position.y;
//            Remaked_objects[i].y = panels[0].transform.GetChild(i).rotation.y;
//            Remaked_objects[i].y = panels[0].transform.GetChild(i).localScale.y;



//            Remaked_objects[i].z = panels[0].transform.GetChild(i).position.z;
//            Remaked_objects[i].z = panels[0].transform.GetChild(i).rotation.z;
//            Remaked_objects[i].z = panels[0].transform.GetChild(i).localScale.z;
//        }

//    }
//    private void restarting()
//    {

//        for (int i = 0; i < gameObject.transform.childCount + 1; i++)
//        {
//            gameObject.transform.GetChild(i).position = new Vector3(Remaked_objects[i].x, Remaked_objects[i].y, Remaked_objects[i].z);
//            gameObject.transform.GetChild(i).rotation = Quaternion.Euler(Remaked_objects[i].x, Remaked_objects[i].y, Remaked_objects[i].z);
//            gameObject.transform.GetChild(i).localScale = new Vector3(Remaked_objects[i].x, Remaked_objects[i].y, Remaked_objects[i].z);
//        }
//    }
//    private void returning()
//    {

//        for (int i = 0; i < gameObject.transform.childCount; i++)
//        {
//            panels[0].transform.GetChild(i).position = new Vector3(Remaked_objects[i].x, Remaked_objects[i].y, Remaked_objects[i].z);
//            panels[0].transform.GetChild(i).rotation = Quaternion.Euler(Remaked_objects[i].x, Remaked_objects[i].y, Remaked_objects[i].z);
//            panels[0].transform.GetChild(i).localScale = new Vector3(Remaked_objects[i].x, Remaked_objects[i].y, Remaked_objects[i].z);
//        }
//    }

//    public void Show()
//    {

//        Application.OpenURL("https://www.instagram.com/traffictour/");
//    }

//    public void test()
//    {
//        Sequence Mysequence = DOTween.Sequence();

//    }
//    public void Game_Menu_tweens()
//    {

//        Tweeens.Add(MyObjects[0].transform.DOScale(MyPositions[0], Duration));
//        Tweeens.Add(MyObjects[1].transform.DOScale(MyPositions[1], Duration2));
//        Tweeens.Add(MyObjects[1].transform.DOMoveX(positions[4], Duration2, MyBoll).SetEase(Ease.OutExpo));
//        Tweeens.Add(MyObjects[1].transform.DORotate(circle, Duration2, RotateMode.FastBeyond360));
//        Tweeens.Add(MyObjects[2].transform.DOScale(MyPositions[2], Duration));
//        Tweeens.Add(MyObjects[3].transform.DOMoveX(positions[0], Duration2, MyBoll));
//        Tweeens.Add(MyObjects[4].transform.DOMoveY(positions[1], Duration2 * 1 / 4, MyBoll).SetEase(Ease.OutBack));
//        Tweeens.Add(MyObjects[5].transform.DOMoveY(positions[2], Duration2 * 1 / 3, MyBoll).SetEase(Ease.OutBack));
//        Tweeens.Add(MyObjects[6].transform.DOMoveY(positions[2], Duration2 * 1 / 2, MyBoll).SetEase(Ease.OutBack));
//        Tweeens.Add(MyObjects[7].transform.DOMoveY(positions[3], Duration2 * 1, MyBoll).SetEase(Ease.OutBack));


//    }
//    public void Game_Menu_Save_positions()
//    {
//        My_Saved_transforms[0].position = MyObjects[0].position;
//        My_Saved_transforms[1].position = MyObjects[1].position;
//        My_Saved_transforms[2].position = MyObjects[2].position;
//        My_Saved_transforms[3].position = MyObjects[3].position;
//        My_Saved_transforms[4].position = MyObjects[4].position;
//        My_Saved_transforms[5].position = MyObjects[5].position;
//        My_Saved_transforms[6].position = MyObjects[6].position;
//        My_Saved_transforms[7].position = MyObjects[7].position;
//        My_Saved_transforms[0].localScale = MyObjects[0].localScale;
//        My_Saved_transforms[1].localScale = MyObjects[1].localScale;
//        My_Saved_transforms[2].localScale = MyObjects[2].localScale;
//        My_Saved_transforms[3].localScale = MyObjects[3].localScale;
//        My_Saved_transforms[4].localScale = MyObjects[4].localScale;
//        My_Saved_transforms[5].localScale = MyObjects[5].localScale;
//        My_Saved_transforms[6].localScale = MyObjects[6].localScale;
//        My_Saved_transforms[7].localScale = MyObjects[7].localScale;
//        My_Saved_transforms[0].rotation = MyObjects[0].rotation;
//        My_Saved_transforms[1].rotation = MyObjects[1].rotation;
//        My_Saved_transforms[2].rotation = MyObjects[2].rotation;
//        My_Saved_transforms[3].rotation = MyObjects[3].rotation;
//        My_Saved_transforms[4].rotation = MyObjects[4].rotation;
//        My_Saved_transforms[5].rotation = MyObjects[5].rotation;
//        My_Saved_transforms[6].rotation = MyObjects[6].rotation;
//        My_Saved_transforms[7].rotation = MyObjects[7].rotation;

//    }
//    public void reset_POS()
//    {
//        DOTween.KillAll();
//        MyObjects[0].position = My_Saved_transforms[0].position;
//        MyObjects[1].position = My_Saved_transforms[1].position;
//        MyObjects[2].position = My_Saved_transforms[2].position;
//        MyObjects[3].position = My_Saved_transforms[3].position;
//        MyObjects[4].position = My_Saved_transforms[4].position;
//        MyObjects[5].position = My_Saved_transforms[5].position;
//        MyObjects[6].position = My_Saved_transforms[6].position;
//        MyObjects[7].position = My_Saved_transforms[7].position;
//        MyObjects[0].localScale = My_Saved_transforms[0].localScale;
//        MyObjects[1].localScale = My_Saved_transforms[1].localScale;
//        MyObjects[2].localScale = My_Saved_transforms[2].localScale;
//        MyObjects[3].localScale = My_Saved_transforms[3].localScale;
//        MyObjects[4].localScale = My_Saved_transforms[4].localScale;
//        MyObjects[5].localScale = My_Saved_transforms[5].localScale;
//        MyObjects[6].localScale = My_Saved_transforms[6].localScale;
//        MyObjects[7].localScale = My_Saved_transforms[7].localScale;
//        MyObjects[0].rotation = My_Saved_transforms[0].rotation;
//        MyObjects[1].rotation = My_Saved_transforms[1].rotation;
//        MyObjects[2].rotation = My_Saved_transforms[2].rotation;
//        MyObjects[3].rotation = My_Saved_transforms[3].rotation;
//        MyObjects[4].rotation = My_Saved_transforms[4].rotation;
//        MyObjects[5].rotation = My_Saved_transforms[5].rotation;
//        MyObjects[6].rotation = My_Saved_transforms[6].rotation;
//        MyObjects[7].rotation = My_Saved_transforms[7].rotation;

//    }
//    public void Game_lose()
//    {

//        Tweeens.Add(MyObjects[8].transform.DOScale(MyPositions[0], Duration));
//        Tweeens.Add(MyObjects[9].transform.DOScale(MyPositions[1], Duration2));
//        Tweeens.Add(MyObjects[9].transform.DOMoveX(positions[4], Duration2, MyBoll).SetEase(Ease.OutExpo));
//        Tweeens.Add(MyObjects[9].transform.DORotate(circle, Duration2, RotateMode.FastBeyond360));
//        Tweeens.Add(MyObjects[10].transform.DOMoveX(positions[0], Duration2, MyBoll));
//        Tweeens.Add(MyObjects[11].transform.DOScale(MyPositions[3], Duration).SetEase(Ease.OutBack));

//    }

//    public void Game_Info()
//    {

//        Tweeens.Add(MyObjects[12].transform.DOMoveX(positions[0], Duration2, MyBoll));
//    }
//    float xAxis;
//    public void Game_Levels()
//    {
//        xAxis = MyObjects[13].transform.localPosition.x;
//        Tweeens.Add(MyObjects[13].transform.DOMoveX(positions[0], Duration2, MyBoll));
//    }
//    public void Game_levels_Part()
//    {

//        Tweeens.Add(MyObjects[14].transform.DOMoveX(positions[0], Duration2, MyBoll));
//        for (int i = 0; i < bottoms.Length; i++)
//        {
//            Tweeens.Add(bottoms[i].transform.DOScale(MyPositions[4], Duration * 1 / 2));
//        }

//    }
//    void Start()
//    {
//        Remake_My_Game();
//        Game_Info();
//        Game_lose();
//        Game_Menu_Save_positions();
//        Game_Menu_tweens();

//    }
//    public void Go_To_Main_menu()
//    {

//        panels[0].SetActive(true);
//        panels[1].SetActive(false);
//        panels[2].SetActive(false);
//        panels[3].SetActive(false);
//        panels[4].SetActive(false);

//        Game_Menu_tweens();
//    }
//    public void Go_To_Game_Info()
//    {

//        panels[0].SetActive(false);
//        panels[1].SetActive(true);
//        panels[2].SetActive(false);
//        panels[3].SetActive(false);
//        panels[4].SetActive(false);
//        reset_POS();
//        Game_Info();
//    }
//    public void Go_To_Levels()
//    {

//        panels[0].SetActive(false);
//        panels[1].SetActive(false);
//        panels[2].SetActive(true);
//        panels[3].SetActive(false);
//        panels[4].SetActive(false);

//        Game_Levels();
//    }
//    public void Go_to_First_Part()
//    {

//        panels[0].SetActive(false);
//        panels[1].SetActive(false);
//        panels[2].SetActive(false);
//        panels[3].SetActive(true);
//        panels[4].SetActive(false);

//        MyObjects[13].transform.localPosition = new Vector3(xAxis, MyObjects[13].transform.localPosition.y, MyObjects[13].transform.localPosition.z);
//        Game_levels_Part();
//    }

//}
