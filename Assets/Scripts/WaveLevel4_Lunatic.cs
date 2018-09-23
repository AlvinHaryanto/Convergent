using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveLevel4_Lunatic : MonoBehaviour {

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
		if (!FirstBoss.GetComponent<Enemy> ().isDead() && GR.BeginTheGame == true) {
			PatternBos1 ();
		}
	}

	void PatternBos1() {
      
        BSPAWN.addBullet(7, 0);//1
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(2, 3);

        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(1, 4);


        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 1);

        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 1);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);

        //10 
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(5, 2);

        //11
        BSPAWN.addBullet(6, 2);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(0, 4);

        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(0, 2);
   
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(2, 1);
    
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(1, 2);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(4, 3);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(5, 2);

        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(5, 4);

        BSPAWN.addBullet(6, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);

        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(2, 1);

        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(2, 2);
        BSPAWN.addBullet(1, 2);

        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 3);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(0, 0);

        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(5, 2);

        //27
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(5, 4);//31
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(5, 2);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(4, 3);

        BSPAWN.addBullet(6, 2);//35
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(6, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(4, 1);//37
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(4, 3);//38
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(6, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(4, 1);

        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(3, 3);
        //45
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(4, 1);

        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(5, 2);
        //47
        BSPAWN.addBullet(6, 2);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(2, 3);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(4, 1);

        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(5, 2);

        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(5, 0);

        BSPAWN.addBullet(6, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(4, 1);

        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(0, 2);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(0, 1);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(5, 2);

        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 3);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(3, 3);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        //end
    }


}
