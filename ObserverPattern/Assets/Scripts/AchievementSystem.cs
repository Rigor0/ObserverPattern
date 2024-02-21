using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : MonoBehaviour 
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();

        PointOfInterest.OnPointOfInterestEntered += OnPointOfInterestEnteredHandler;
    }

    private void OnPointOfInterestEnteredHandler(PointOfInterest poi)
    {
        string achievementKey = "achievement-" + poi.PoiName;

        if (PlayerPrefs.GetInt(achievementKey) == 1)
            return;

        PlayerPrefs.SetInt(achievementKey, 1);
        Debug.Log("Unlocked" +  poi.PoiName);
    }
    
}

