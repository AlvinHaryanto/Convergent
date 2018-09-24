using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cd_RestartLevel : MonoBehaviour {
    
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && PlayerPrefs.GetString("Result")=="game over")
        {
            SceneManager.LoadScene(PlayerPrefs.GetString("LastLevelPlayed","MainMenu(Demo)"));
        }
	}
}
