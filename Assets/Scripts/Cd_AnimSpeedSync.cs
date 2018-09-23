using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cd_AnimSpeedSync : MonoBehaviour {
    private Animator anim;
    public float bpm;
	// Use this for initialization
	void Awake () {
        anim = GetComponent<Animator>();
        anim.speed = bpm / 120;
	}
}
