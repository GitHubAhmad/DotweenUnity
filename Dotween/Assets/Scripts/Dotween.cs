using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Dotween : MonoBehaviour {
    public bool myBool;
    public int duration;
    public GameObject Player;

    public Material MyMat;
    public Light MyLight;
    public Vector3[] Points;

    public float Speed;
	// Use this for initialization
	void Start () {
        //Points = new Vector3[5];
       // Points[0] = transform.position;
        
	}
	        
	// Update is called once per frame
	void Update () {

        //transform.Translate(Input.GetAxis("Horizontal") * Speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * Speed * Time.deltaTime);
        //_______________________ DOTWEEN(Transform)__________________________

        Player.transform.DOMove(new Vector3(0, 0, 0), 5, !myBool);
        Player.transform.DOMoveX(500, duration, myBool);
        Player.transform.DOMoveY(500, duration, myBool);
        Player.transform.DOMoveZ(500, duration, myBool);
        Player.transform.DOLocalMoveX(500, duration, myBool);
        Player.transform.DOLocalMoveY(500, duration, myBool);
        Player.transform.DOLocalMoveZ(500, duration, myBool);
        Player.transform.DOJump(new Vector3(0, 1, 0), 1, 5, 1, !myBool);//dont work
        Player.transform.DORotate(new Vector3(50, 90, 80), duration, RotateMode.Fast);
        Player.transform.DOLocalRotate(new Vector3(50, 90, 80), duration, RotateMode.Fast);
        Player.transform.DOLookAt(Player.transform.position, duration, AxisConstraint.None, Vector3.up);
        Player.transform.DOScale(new Vector3(8, 95, 999), duration);
        Player.transform.DOPunchPosition(transform.position, duration, 10, 1, myBool);
        Player.transform.DOPunchScale(transform.position, duration, 10, 1);
        Player.transform.DOPath(Points, duration, PathType.Linear, PathMode.Full3D, 10, Color.red); __!__
        Player.transform.DOBlendableMoveBy(Player.transform.position, duration, myBool); __!__
        Player.transform.DOBlendableRotateBy(Player.transform.position, duration, RotateMode.Fast); __!__
        Player.transform.DOBlendableScaleBy(Player.transform.position, duration); __!__
        // _______________________ DOTWEEN(Light)__________________________
        // MyLight.DOColor(Color.blue, duration);
        //MyLight.DOIntensity(50, duration);
        //MyLight.DOShadowStrength(1, duration);
        //_______________________ DOTWEEN(Material)__________________________
        //MyMat.DOColor(Color.yellow, duration);
        //MyMat.DOFade(0, duration); __!__



    }

}
