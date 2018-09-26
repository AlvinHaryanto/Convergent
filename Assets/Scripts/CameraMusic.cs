using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMusic : MonoBehaviour {
    public BulletSpawn bulletSpawn;
	public AudioClip BGM;
	GetReady GR;
    
	void Start ()
    {
        GR = FindObjectOfType<GetReady>();
        BackMusic.instance.source.mute = false;
        //StartCoroutine (PlayingMusic ());
        if (SceneManager.GetActiveScene ().name == "Mainmenu(Demo)" ||
			SceneManager.GetActiveScene ().name == "Options" ||
			SceneManager.GetActiveScene ().name == "Gameover(Demo)" ||
			SceneManager.GetActiveScene ().name == "How2Play"||
            SceneManager.GetActiveScene().name == "SelectLevel-V2" ||
            SceneManager.GetActiveScene().name == "Credits"
            )
		{
            if (!BackMusic.instance.source.isPlaying||BackMusic.instance.source.clip!=BGM)
            {
                BackMusic.instance.PlayMusic(BGM);

            }
		}else {
			StartCoroutine (PlayingMusic ());
		}

		/*if (SceneManager.GetActiveScene ().name == "Song1Easy") {
			StartCoroutine (PlayingMusic ());
		} else {
			BackMusic.instance.PlayMusic (BGM);
		}*/


	}

	IEnumerator PlayingMusic() {
		BackMusic.instance.source.mute = true;
		yield return new WaitForSeconds (GR.preparationTime + bulletSpawn.timer);
		BackMusic.instance.PlayMusic (BGM);
		BackMusic.instance.source.mute = false;
	}

}
	

