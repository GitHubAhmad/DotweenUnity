using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;


public class StoreManager : MonoBehaviour
{


    public Text Dimond_value;
    public void OnPurchesComplete(Product product)
    {
        if (product != null)
        {
            switch (product.definition.id)
            {
                case "dimonds_100":
                    Debug.Log("you have 100 dimonds more");
                    int current_Dimond_100 = int.Parse(Dimond_value.text);
                    Dimond_value.text = (current_Dimond_100 + 100).ToString();
                    Debug.Log(Dimond_value);
                    break;
                case "dimonds_300":
                    Debug.Log("you have 300 dimonds more");
                    int current_Dimond_300 = int.Parse(Dimond_value.text);
                    Dimond_value.text = (current_Dimond_300 + 300).ToString();
                    Debug.Log(Dimond_value);
                    break;
                case "dimonds_500":
                    Debug.Log("you have 500 dimonds more");
                    int current_Dimond_500 = int.Parse(Dimond_value.text);
                    Dimond_value.text = (current_Dimond_500 + 500).ToString();
                    Debug.Log(Dimond_value);
                    break;
                default:
                    Debug.Log("sorry the prodect is not defined");

                    break;

            }

        }
    }
}
