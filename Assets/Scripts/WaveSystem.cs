using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour {

	BulletSpawn BSPAWN;
	public GameObject FirstBoss;


	void Start() {
		//BSPAWN = GameObject.Find ("BulletSpawn").GetComponent<BulletSpawn> ();
		BSPAWN = FindObjectOfType<BulletSpawn>();

		//BSPAWN.addBullet (1, 2);

	}

	void Update() {
		if (!FirstBoss.GetComponent<Enemy> ().isDead()) {
			PatternBos1 ();
		}
	}

	void PatternBos1() {
		//1-40
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (1, 4);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		//Sampe 150
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(1,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(1,0);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,0);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(1,0);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(0,1);
		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(0,2);

		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (1, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (1, 4);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (1, 4);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (0, 2);
	}


}
