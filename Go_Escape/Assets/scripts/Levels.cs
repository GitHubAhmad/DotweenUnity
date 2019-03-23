using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{

    public enum Type { Locked, Unlocked }


    public Type levelType;
    public int LevelNum;
    public Sprite LockImage, Unlockimage;


    public Button ThisButton;

    public Text LevelText;


    // Start is called before the first frame update
    void Start()
    {
        ThisButton = GetComponent<Button>();
        LevelText = ThisButton.transform.GetChild(0).GetComponent<Text>();

        if (levelType == Type.Locked)
        {
            ThisButton.image.sprite = LockImage;
            LevelText.enabled = false;
        }
        else
        {
            LevelText.enabled = true;
            ThisButton.image.sprite = Unlockimage;
            LevelText.text = LevelNum.ToString();
        }
    }


    // Update is called once per frame
    void Update()
    {

    }



}
