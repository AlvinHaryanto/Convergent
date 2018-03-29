using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Animator plyrAnim;
	public Transform left, mid, right;

	private Vector3 startPos, endPos;

	//public float Timer = 1f;
	private float currentTime;

	private bool move;

	//private Vector3 testTarget, testTarget2;
	public float speed = 10f;

	void Start() {
        /*
		testTarget = right.position;
		testTarget2 = left.position;
        */
        plyrAnim = GetComponent<Animator>();
    }

    void Update() {
		startPos = transform.position;
        if (endPos==transform.position) {
            plyrAnim.SetBool("MoveLeft",false);
            plyrAnim.SetBool("MoveRight",false);
        }
		if (transform.position == left.position) {
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				endPos = mid.position;
				move = true;
                plyrAnim.SetBool("MoveRight",true);
                plyrAnim.SetBool("MoveLeft", false);
            }

		} else if (transform.position == right.position) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				endPos = mid.position;
				move = true;
                plyrAnim.SetBool("MoveRight", false);
                plyrAnim.SetBool("MoveLeft", true);
            }

		} else if(transform.position == mid.position) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				endPos = left.position;
				move = true;
                plyrAnim.SetBool("MoveRight", false);
                plyrAnim.SetBool("MoveLeft", true);

            } else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				endPos = right.position;
				move = true;
                plyrAnim.SetBool("MoveRight", true);
                plyrAnim.SetBool("MoveLeft", false);
            }
		}


		if (move == true) {
			transform.position = Vector3.MoveTowards (startPos, endPos, speed * Time.deltaTime);
		}

	}
}
