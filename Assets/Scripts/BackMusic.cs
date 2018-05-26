using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusic : MonoBehaviour {

    public static BackMusic instance;
    public AudioSource source;
    
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }
    }

	public void PlayMusic(AudioClip clip) {
		source.clip = clip;
		source.Play ();
	}

    public void SetVolume(float x)
    {
        source.volume = x;
    }

    public float GetVolume()
    {
        return source.volume;
    }




}
