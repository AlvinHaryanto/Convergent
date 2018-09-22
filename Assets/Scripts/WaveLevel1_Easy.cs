using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveLevel1_Easy : MonoBehaviour {
    private bool hasLoaded=false;
	BulletSpawn BSPAWN;
	public GameObject FirstBoss;
	GetReady GR;
    //0: Normal - Undeflectable
    //1: Normal - Deflectable
    //2: Offlane- Deflectable - Left
    //3: Offlane- Deflectable - Right
    //4: Offlane- Undeflectable
    //5: Split (undeflectable only)
    //6: Missile (deflectable MUST)
    //7: Empty / Silent (ada bagian di pattern yang kosong)
    //8: Ghost - Undeflectable
    void Start() {
		//BSPAWN = GameObject.Find ("BulletSpawn").GetComponent<BulletSpawn> ();
		BSPAWN = FindObjectOfType<BulletSpawn>();
		GR = FindObjectOfType<GetReady> ();

		//BSPAWN.addBullet (1, 2);

	}

	void Update() {
		if (!FirstBoss.GetComponent<Enemy> ().isDead() && GR.BeginTheGame == true&&!hasLoaded) {
			PatternBos1 ();
            hasLoaded = true;
		}
	}

	void PatternBos1() {
        //1-40
        BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (0, 0);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 4);
		//Sampe 150
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);

		BSPAWN.addBullet(7,4);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);

		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(7,4);
		BSPAWN.addBullet(7,4);

		BSPAWN.addBullet(7,4);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(0,0);

		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(0,4);

		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(7,4);
		BSPAWN.addBullet(0,0);

		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(0,2);

		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(7,4);
		BSPAWN.addBullet(7,4);
		BSPAWN.addBullet(7,4);

		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,2);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(7,0);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(7,4);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,2);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(0,4);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(0,4);
		BSPAWN.addBullet(7,4);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,0);
		BSPAWN.addBullet(0,0);
		BSPAWN.addBullet(7,0);

		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(1,2);
		BSPAWN.addBullet(0,2);
		BSPAWN.addBullet(7,2);

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
        //checkpoint
		BSPAWN.addBullet(7,0);
		BSPAWN.addBullet(7,4);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(1,4);

		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet(1,0);
		BSPAWN.addBullet(7,4);
		BSPAWN.addBullet(7,2);

		BSPAWN.addBullet(1,4);
		BSPAWN.addBullet(7,2);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 2);

		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (1, 4);

		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (1, 0);

		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 2);

		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (1, 2);

		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (1, 2);

		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (0, 0);

		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 0);

		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);

		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (0, 2);

		BSPAWN.addBullet (0, 4);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 2);

		BSPAWN.addBullet (0, 2);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 2);
		BSPAWN.addBullet (7, 2);

		BSPAWN.addBullet (1, 2);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (7, 4);

		BSPAWN.addBullet (7, 4);
		BSPAWN.addBullet (1, 0);
		BSPAWN.addBullet (7, 0);
		BSPAWN.addBullet (7, 2);
	}


}
