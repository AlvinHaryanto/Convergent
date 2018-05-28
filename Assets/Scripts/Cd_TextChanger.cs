using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cd_TextChanger : MonoBehaviour {
    private Text ResultText; 
	// Use this for initialization
	void Start () {
        ResultText = GetComponent<Text>();
        if (PlayerPrefs.GetString("Result")=="")
        {
            ResultText.text = "game over";
        }
        else {
            ResultText.text = PlayerPrefs.GetString("Result");
        }
	}
	
}
