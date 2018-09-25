using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour {

    public static SFX instance;
    public AudioSource source;

	public AudioClip mampus, menang, startt, tick321;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

	public void PlayMampus() {
		source.PlayOneShot (mampus);
	}

	public void PlayMenang() {
		source.PlayOneShot (menang);
	}

	public void PlayStartt() {
		source.PlayOneShot (startt);
	}

	public void PlayTick321() {
		source.PlayOneShot (tick321);
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
