using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Dotween : MonoBehaviour {
    // public bool myBool;
    // public int duration;
    // public GameObject Player;

    // public Material MyMat;
    // public Light MyLight;
    // public Vector3 []Points;

    //public Material mymat;


    //public float Speed;
    // Use this for initialization

    public GameObject[] Cubes;

    public GameObject a1;
    public GameObject a2;

    public Text NumText;
    public int Num;
	void Start () {


        Sequence mySequence = DOTween.Sequence();

        //mySequence.Append(NumText.DOText((++Num).ToString(), 0.1f));
        //mySequence.SetLoops(100, LoopType.Restart);


        Sits[0] = "https://www.youtube.com/";
        Sits[1] = "https://web.whatsapp.com/";




        //Points = new Vector3[5];
        // Points[0] = transform.position;
        //Sequence mysequence = DOTween.Sequence();
        //mysequence.Append(Player.transform.DOMove(new Vector3(0,1,0), 1, !myBool).SetEase(Ease.OutQuad));
        //mysequence.Append(mymat.DOColor(Color.blue, 0.1f)).AppendCallback(() => { Debug.Log(Player.transform.position); });
        //mysequence.Append(Player.transform.DOMove(new Vector3(0, 17, 0), 0.8F, !myBool).SetEase(Ease.OutQuad));
        //mysequence.Append(Player.transform.DOMove(new Vector3(0, 17, 10000), 0.5F, !myBool).SetEase(Ease.InExpo));
        //mysequence.Append(Player.transform.DOScale(new Vector3(100, 100, 100), 0.1f).SetEase(Ease.InExpo));
        //mysequence.Append(mymat.DOColor(Color.black, 0.1f));
        //mysequence.Append(Player.transform.DOMove(new Vector3(0, 17, 13.8f), 3, !myBool).SetEase(Ease.OutExpo));
        //mysequence.SetLoops(-1, LoopType.Restart);
        /*.SetLoops(3,LoopType.Yoyo)*/
        //mysequence.Append(Player.transform.DOScale(new Vector3(1, 1, 1), 0.8f));
        //Player.transform.DOMove(new Vector3(10, 10, 10), 2).SetEase(Ease.Flash);
        //List<Tween> tweens = new List<Tween>();

        //Sequence mysequence = DOTween.Sequence();
        //tweens.Add(  mysequence.Insert(1, Cubes[0].transform.DOMove(Cubes[1].transform.position, 1)));
        //tweens.Add( mysequence.Insert(1, Cubes[1].transform.DOMove(Cubes[2].transform.position, 1)));
        //tweens.Add( mysequence.Insert(1, Cubes[2].transform.DOMove(Cubes[3].transform.position, 1)));
        //tweens.Add( mysequence.Insert(1, Cubes[3].transform.DOMove(Cubes[4].transform.position, 1)));
        //tweens.Add( mysequence.Insert(1, Cubes[4].transform.DOMove(Cubes[5].transform.position, 1)));
        //tweens.Add( mysequence.Insert(1, Cubes[5].transform.DOMove(Cubes[0].transform.position, 1)));
        //DOTween.PausedTweens(tweens);
        //mysequence.SetLoops(-1, LoopType.Restart);
        //bool a = GameObject.ReferenceEquals(a1, a2);

        //if (a)
        //{
        //    Debug.Log("Same");
        //}
        //else
        //{
        //    Debug.Log("NotSame");
        //}  
    }

    // Update is called once per frame
    void Update () {      
        //transform.Translate(Input.GetAxis("Horizontal") * Speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * Speed * Time.deltaTime);
        //_______________________ DOTWEEN(Transform)__________________________      
        //mysequence.onComplete(Debug.Log(Player.transform.position));       
            //Player.transform.DOMove(Points, 5, !myBool);
            //if (Player.transform.position == Points)
            //{
            //    Debug.Log(Points);
            //}    
        //Player.transform.DOMoveY(500, duration, myBool);
        //Player.transform.DOMoveZ(500, duration, myBool);
        //Player.transform.DOLocalMoveX(500, duration, myBool);
        //Player.transform.DOLocalMoveY(500, duration, myBool);
        //Player.transform.DOLocalMoveZ(500, duration, myBool);
        //Player.transform.DOJump(new Vector3(0, 1, 0), 1, 5, 1, !myBool);//dont work
        //Player.transform.DORotate(new Vector3(50, 90, 80), duration, RotateMode.Fast);
        //Player.transform.DOLocalRotate(new Vector3(50, 90, 80), duration, RotateMode.Fast);
        //Player.transform.DOLookAt(Player.transform.position, duration, AxisConstraint.None, Vector3.up);
        //Player.transform.DOScale(new Vector3(8, 95, 999), duration);
        //Player.transform.DOPunchPosition(transform.position, duration, 10, 1, myBool);
        //Player.transform.DOPunchScale(transform.position, duration, 10, 1);
        //Player.transform.DOPath(Points, duration, PathType.Linear, PathMode.Full3D, 10, Color.red); 
        //Player.transform.DOBlendableMoveBy(Player.transform.position, duration, myBool); 
        //Player.transform.DOBlendableRotateBy(Player.transform.position, duration, RotateMode.Fast); 
        //Player.transform.DOBlendableScaleBy(Player.transform.position, duration);
        // _______________________ DOTWEEN(Light)__________________________
        // MyLight.DOColor(Color.blue, duration);
        //MyLight.DOIntensity(50, duration);
        //MyLight.DOShadowStrength(1, duration);
        //_______________________ DOTWEEN(Material)__________________________
        //MyMat.DOColor(Color.yellow, duration);
        //MyMat.DOFade(0, duration); __!__

    }
    string[] Sits = new string[2];
   
    public void GoRandomSite()
    {
       
        Application.OpenURL(Sits[Random.Range(0,Sits.Length)]);
    }

}
