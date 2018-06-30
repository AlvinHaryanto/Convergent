using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveLevel2_Hard : MonoBehaviour {

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
        //1-32 bar 1-8
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(1, 0);

        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);

        //bar 9-24 pattern 16x4 = 64
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(5, 4);

        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(4, 3);

        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(4, 1);

        /*_____________________________________________________*/

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(1, 4);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(4, 3);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 0);

        //bar 25-32
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(4, 3);

        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(0, 2);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 1);

        //33-36
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(5, 2);

        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(5, 2);

        //37-40
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(7, 3);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 3);

        
        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(7, 1);

        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(5, 4);
        //41 - 48
        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(5, 2);

        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(5, 2);

        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(0, 4);
        //44
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(5, 4);
        //45
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(2, 3);
        //46
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(0, 2);
        //47
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(1, 2);
        //48
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(5, 0);
        /**/

        //49-64
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);
        //50
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(2, 3);
        //51
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(5, 0);
        //52
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(7, 0);//4bar
        //53
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(5, 4);
        //54
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        //55
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(5, 4);
        //56
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(7, 0);
        //57
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(7, 0);//CP
        //58
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(1, 3);
        BSPAWN.addBullet(1, 1);
        //59
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(0, 4);
        //60
        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(4, 3);
        //61
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(5, 0);
        //62
        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        //63
        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(7, 4);
        //64
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(3, 3);

        //65-72
        //cp
        //65
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(5, 2);
        //66
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(5, 4);
        //67
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);
        //68
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(5, 0);
        //69
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(5, 4);
        //70
        //cp
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(4, 1);
        //71
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(5, 0);
        //72
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(1, 2);


    }


}
