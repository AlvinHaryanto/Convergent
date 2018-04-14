using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

	public GameObject bullet;
	public GameObject undeflectable;
	public GameObject offlane;
	public GameObject offlaneUndeflectable;
	public float timer;

	Vector3 location;

	private float offlaneLeft, offlaneRight;
	int DeflectDir;
	int BulletChooser;
	float count;
	GameObject tempBullet;

	private void Start() {
		location = new Vector3 (0, 0, 67.59f);
		count = 0;

		offlaneLeft = -3.3f;
		offlaneRight = 3.48f;
	}

	public int GetChooser() {
		return BulletChooser;
	}

	void Update() {
		//Debug.Log (count);
		count += Time.deltaTime;

		int randomizer;
		if (count >= timer) {
			//Debug.Log ("timer done");

			BulletChooser = Random.Range (1, 20);
			randomizer = Random.Range (1, 20);
			DeflectDir = Random.Range (1, 20);
			//Debug.Log (randomizer);

			if (randomizer >= 1 && randomizer < 4) {
				location.x = -7.27f;

			} else if (randomizer >= 4 && randomizer < 8) {
				location.x = 0f;
			} else if (randomizer >= 8 && randomizer < 12) {
				location.x = 7.27f; 
			
			//BULLET OFFLANE
			} else if (randomizer >= 12 && randomizer < 16) {
				location.x = offlaneLeft;
			}else {
				location.x = offlaneRight;
			}

			if (BulletChooser >= 1 && BulletChooser <= 10) { //BULLET is DEFLECTABLE
				
				if (location.x == offlaneLeft || location.x == offlaneRight) { //KL BULLETNYA OFFLANE MAKA
					tempBullet = Instantiate (offlane, location, bullet.transform.rotation);
					tempBullet.GetComponent<BulletMovement> ().setLaneID (1); 
					//reference di bullet movement, kalau lane id = 1 artinya bulletnya offlane

					//spawn deflectable offlane
					//deflect dir randomizes deflect direction of bullet
					if (DeflectDir > 10) { //OFFLANE ITU CARA DEFLECTNYA ADA 2, BISA KIRI BISA KANAN. 
						//Kl DeflectDir > 10, maka deflect ke kiri 
						
						tempBullet.GetComponent<BulletMovement> ().setDeflectDir (0); //Maka deflectDir nya diset ke kiri
					} else { //Kalau DeflectDir <= 10, maka deflect ke kanan
						tempBullet.GetComponent<BulletMovement> ().setDeflectDir (1); //deflect dir di bullet nya di set ke kanan
						//terus modelnya dibalik
						tempBullet.GetComponent<BulletMovement> ().Model.transform.localScale=new Vector3(-1*tempBullet.GetComponent<BulletMovement> ().Model.transform.localScale.x, tempBullet.GetComponent<BulletMovement> ().Model.transform.localScale.y, tempBullet.GetComponent<BulletMovement> ().Model.transform.localScale.z);

					}
				} else {
					tempBullet=Instantiate (bullet, location, bullet.transform.rotation);
				}

			} else { //BULLET IS UNDEFLECTABLE
				if (location.x == offlaneLeft || location.x == offlaneRight) { 
					tempBullet = Instantiate (offlaneUndeflectable, location, bullet.transform.rotation);
				} else {
					tempBullet=Instantiate (undeflectable, location, bullet.transform.rotation);
				}


			}


			count = 0;
		}



	}
		

}
