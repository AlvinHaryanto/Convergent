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
	private float offlaneLeft, offlaneRight;
	//private Vector3 testTarget, testTarget2;
	public float speed = 10f;


	int PlayerDir=0;
	//0=to left;
	//1=to right;
	//2=sudah sampai;

	void Start() {
        /*
		testTarget = right.position;
		testTarget2 = left.position;
        */
        plyrAnim = GetComponent<Animator>();
		offlaneLeft = -3.3f;
		offlaneRight = 3.48f;
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
		if (transform.position == left.position || transform.position == mid.position || transform.position == right.position) {
			PlayerDir = 2;
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				PlayerDir = 1;
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				PlayerDir = 0;
			}
		}


		if (move == true) {
			transform.position = Vector3.MoveTowards (startPos, endPos, speed * Time.deltaTime);
		}
	}
	public int getPlayerDir(){
		return PlayerDir;
	}
	
}
