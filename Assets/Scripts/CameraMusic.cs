using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMusic : MonoBehaviour {

	public AudioClip BGM;
	GetReady GR;


	void Awake() {
		GR = FindObjectOfType<GetReady> ();
		if (SceneManager.GetActiveScene ().name != "Song1Easy") {
			BackMusic.instance.source.mute = false;
		}

	}
	void Start () {
		
		if (SceneManager.GetActiveScene ().name == "Song1Easy") {
			StartCoroutine (PlayingMusic ());
		} else {
			BackMusic.instance.PlayMusic (BGM);
		}


	}

	IEnumerator PlayingMusic() {
		BackMusic.instance.source.mute = true;
		yield return new WaitForSeconds (GR.preparationTime - 1);
		BackMusic.instance.PlayMusic (BGM);
		BackMusic.instance.source.mute = false;
	}

}
	

