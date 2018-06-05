using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMusic : MonoBehaviour {

	public AudioClip BGM;
	GetReady GR;

	void Awake() {
		GR = FindObjectOfType<GetReady> ();
		if (SceneManager.GetActiveScene ().name != "TryOut") {
			BackMusic.instance.source.mute = false;
		}

	}
	void Start () {
		
		if (SceneManager.GetActiveScene ().name == "TryOut") {
			StartCoroutine (PlayingMusic ());
		} else {
			BackMusic.instance.PlayMusic (BGM);
		}


	}

	IEnumerator PlayingMusic() {
		yield return new WaitForSeconds (GR.preparationTime - 1);
		BackMusic.instance.PlayMusic (BGM);
		BackMusic.instance.source.mute = false;
	}

}
	

