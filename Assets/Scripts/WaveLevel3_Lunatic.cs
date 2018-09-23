using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveLevel3_Lunatic : MonoBehaviour {

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
      
        BSPAWN.addBullet(5, 2);//1
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(8, 0);
        BSPAWN.addBullet(7, 3);

        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(8, 4);
        BSPAWN.addBullet(7, 1);

        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(1, 2);

        //5
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(5, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(7, 1);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(2, 3);

        //9
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(5, 4);

        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(0, 4);

        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(5, 4);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(7, 1);

        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(4, 3);
   
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(1, 4);
    
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(8, 4);

        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 3);
        //17
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 2);

        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(7, 4);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 3);

        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 1);
        //21
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(1, 4);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 1);

        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(7, 3);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(7, 2);
   
        //27
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(1, 2);

        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(0, 2);

        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(8, 4);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(0, 2);

        BSPAWN.addBullet(3, 1);//31
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(8, 2);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(7, 0);
        //33
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(7, 2);

        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 3);

        BSPAWN.addBullet(0, 4);//35
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(1, 4);

        BSPAWN.addBullet(0, 2);//37
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 0);//38
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(8, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(4, 4);
        BSPAWN.addBullet(3, 3);
        //41
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(8, 2);

        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(8, 4);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(8, 2);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(8, 0);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(8, 2);

        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(8, 2);
        //45
        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(8, 4);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(8, 2);

        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(0, 4);
        BSPAWN.addBullet(8, 2);
        //47
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(8, 0);
        BSPAWN.addBullet(4, 3);
        BSPAWN.addBullet(8, 0);

        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(8, 2);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(8, 4);
        //49
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(3, 1);

        BSPAWN.addBullet(5, 4);
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 3);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(4, 1);

        BSPAWN.addBullet(0, 0);
        BSPAWN.addBullet(8, 0);
        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(5, 2);
        //54
        BSPAWN.addBullet(8, 4);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(0, 0);

        BSPAWN.addBullet(0, 2);
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(4, 1);
        BSPAWN.addBullet(8, 2);

        BSPAWN.addBullet(3, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 3);
        BSPAWN.addBullet(2, 3);
        //57
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 1);

        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(7, 2);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(7, 4);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(7, 3);

        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(7, 3);
        BSPAWN.addBullet(7, 3);
        //61
        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 2);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(2, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        //65
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(7, 1);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        //69
        BSPAWN.addBullet(5, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 4);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);

        BSPAWN.addBullet(1, 2);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        BSPAWN.addBullet(7, 0);
        //end
    }


}
