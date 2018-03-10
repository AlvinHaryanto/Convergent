using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

	public GameObject bullet;
	public float timer;

	Vector3 location;
	float count;
	private void Start() {
		location = new Vector3 (0, 0, 67.59f);
		count = 0;
	}

	void Update() {
		//Debug.Log (count);
		count += Time.deltaTime;

		int randomizer;
		if (count >= timer) {
			//Debug.Log ("timer done");

			randomizer = Random.Range (1, 10);
			//Debug.Log (randomizer);

			if (randomizer >= 1 && randomizer < 4) {
				location.x = -7.27f;

			} else if (randomizer >= 4 && randomizer < 8) {
				location.x = 0f;
			} else {
				location.x = 7.27f; 
			}

			Debug.Log(location.x);
			Instantiate (bullet, location, bullet.transform.rotation);

			count = 0;
		}



	}
		

}
