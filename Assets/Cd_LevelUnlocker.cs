using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cd_LevelUnlocker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string lastLevel = PlayerPrefs.GetString("LastLevelPlayed", "none");
        if (lastLevel !="none")
        {
            if (PlayerPrefs.GetString("Result")=="victory!")
            {
                PlayerPrefs.SetInt("song"+lastLevel.Substring(4,1)+"lock",1);
                Debug.Log(lastLevel.Substring(4, 1));
                PlayerPrefs.SetInt(lastLevel+"complete",1);
            }
        }
	}
}
