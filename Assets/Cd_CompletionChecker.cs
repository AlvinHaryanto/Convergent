using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cd_CompletionChecker : MonoBehaviour {

    private GameObject silverCrown;
    private GameObject goldCrown;
    private void Start()
    {

        silverCrown = transform.GetChild(0).gameObject;
        goldCrown = transform.GetChild(1).gameObject;
        silverCrown.SetActive(false);
        goldCrown.SetActive(false);
        if (PlayerPrefs.GetInt("song5lock")!=0)
        {
            silverCrown.SetActive(true);
        }
        //check gold crown
        int totalCompletedLevels = 0;
        for(int i = 0; i < 4; i++)
        {
            if (PlayerPrefs.GetInt("Song" + (i + 1) + "Easy"+"complete", 0) != 0)
            {
                totalCompletedLevels++;
            }
            if (PlayerPrefs.GetInt("Song" + (i + 1) + "Medium" + "complete", 0) != 0)
            {
                totalCompletedLevels++;
            }
            if (PlayerPrefs.GetInt("Song" + (i + 1) + "Hard" + "complete", 0) != 0)
            {
                totalCompletedLevels++;
            }
            if (PlayerPrefs.GetInt("Song" + (i + 1) + "Lunatic" + "complete", 0) != 0)
            {
                totalCompletedLevels++;
            }
        }
        if (totalCompletedLevels>=14)
        {
            goldCrown.SetActive(true);
        }
    }
}
