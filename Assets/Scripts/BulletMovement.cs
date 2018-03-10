using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	public float speed;
	Rigidbody rb;
	void Start(){
		rb = GetComponent<Rigidbody> ();
	}
	void Update () {
		rb.velocity = new Vector3 (0f,0f,-1*speed*Time.deltaTime);
		if(transform.position.z<=-10){
			Destroy (gameObject);
		}
	}
}
