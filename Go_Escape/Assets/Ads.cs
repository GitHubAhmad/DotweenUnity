using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;

public class Ads : MonoBehaviour
{
    public StoreManager mystore;
    public void ShowAds()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult });
        }
    }
    private void HandleAdResult(ShowResult Result)
    {
        switch (Result)
        {
            case ShowResult.Finished:
                int current_Dimond_50 = int.Parse(mystore.Dimond_value.text);
                mystore.Dimond_value.text = (current_Dimond_50 + 50).ToString();
                Debug.Log("the video watched ");

                break;
            case ShowResult.Skipped:
                Debug.Log("the video skiped ");
                break;
            case ShowResult.Failed:
                Debug.Log("the video failed to start (internet)!?");
                break;
        }

    }
}
