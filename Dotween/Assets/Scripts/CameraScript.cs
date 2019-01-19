using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraScript : MonoBehaviour {
    public float duration;
	
	void Start () {
		
	}
	
	
	void Update () {
        transform.DOMoveZ(992, duration);
	}
}
