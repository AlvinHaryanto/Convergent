using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMusic : MonoBehaviour {

	public AudioClip BGM;

	void Start () {
		BackMusic.instance.PlayMusic (BGM);
	}

}
	

