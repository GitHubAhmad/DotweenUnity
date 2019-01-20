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

        //gameObject.transform.DOMove(new Vector3(0, 0, 0), 5, !myBool);
        //gameObject.transform.DOMoveX(500, duration, myBool);
        //gameObject.transform.DOMoveY(500, duration, myBool);
        //gameObject.transform.DOMoveZ(500, duration, myBool);
        //gameObject.transform.DOLocalMoveX(500, duration, myBool);
        //gameObject.transform.DOLocalMoveY(500, duration, myBool);
        //gameObject.transform.DOLocalMoveZ(500, duration, myBool);
        //gameObject.transform.DOJump(new Vector3(0, 1, 0), 1, 5, 1, !myBool);//dont work
        //gameObject.transform.DORotate(new Vector3(50, 90, 80), duration, RotateMode.Fast);
        //gameObject.transform.DOLocalRotate(new Vector3(50, 90, 80), duration, RotateMode.Fast);
        //gameObject.transform.DOLookAt(Player.transform.position, duration, AxisConstraint.None, Vector3.up);
        //gameObject.transform.DOScale(new Vector3(8, 95, 999), duration);
        //gameObject.transform.DOPunchPosition(transform.position, duration, 10, 1, myBool);
        //gameObject.transform.DOPunchScale(transform.position, duration, 10, 1);
        //gameObject.transform.DOPath(Points, duration, PathType.Linear, PathMode.Full3D, 10, Color.red); __!__
        //gameObject.transform.DOBlendableMoveBy(Player.transform.position, duration, myBool); __!__
        //gameObject.transform.DOBlendableRotateBy(Player.transform.position, duration, RotateMode.Fast); __!__
        //gameObject.transform.DOBlendableScaleBy(Player.transform.position, duration); __!__
        // _______________________ DOTWEEN(Light)__________________________
        // MyLight.DOColor(Color.blue, duration);
        //MyLight.DOIntensity(50, duration);
        //MyLight.DOShadowStrength(1, duration);
        //_______________________ DOTWEEN(Material)__________________________
        //MyMat.DOColor(Color.yellow, duration);
        //MyMat.DOFade(0, duration); __!__



    }

}
