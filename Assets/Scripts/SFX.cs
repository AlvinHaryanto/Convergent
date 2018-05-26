using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour {

    public static SFX instance;
    public AudioSource source;

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

    public void SetVolume(float x)
    {
        source.volume = x;
    }

    public float GetVolume()
    {
        return source.volume;
    }
}
