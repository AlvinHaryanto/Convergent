using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Transform left, mid, right;

	private Vector3 startPos, endPos;

	//public float Timer = 1f;
	private float currentTime;

	private bool move;

	//private Vector3 testTarget, testTarget2;
	public float speed = 10f;

	/*void Start() {
		testTarget = right.position;
		testTarget2 = left.position;
	} */

	void Update() {
		startPos = transform.position;

		if (transform.position == left.position) {
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				endPos = mid.position;
				move = true;
			}

		} else if (transform.position == right.position) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				endPos = mid.position;
				move = true;
			}

		} else {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				endPos = left.position;
				move = true;

			} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				endPos = right.position;
				move = true;

			}
		}


		if (move == true) {
			transform.position = Vector3.MoveTowards (startPos, endPos, speed * Time.deltaTime);
		}

	}
}
