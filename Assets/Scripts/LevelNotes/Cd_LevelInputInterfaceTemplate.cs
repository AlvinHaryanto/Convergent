using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cd_LevelInputInterfaceTemplate : MonoBehaviour {
    BulletSpawn BSPAWN;
    public GameObject FirstBoss;
    GetReady GR;
    public BulletSpawn bulletSpawn;
    [System.Serializable]
    public class bulletList
    {
        public bool leftLane;
        public bool offLeft;
        public bool midLane;
        public bool offRight;
        public bool rightLane;
        public bool deflectable;
        public bool undeflectable;
        public bool offlaneLeft;
        public bool offlaneRight;
        public bool offLaneUndeflectable;
        public bool split;
        public bool lob;
        public bool ghost;
    }

    public bulletList[] InspectorArray;
    // Use this for initialization
    void Start()
    {
        //BSPAWN = GameObject.Find ("BulletSpawn").GetComponent<BulletSpawn> ();
        BSPAWN = FindObjectOfType<BulletSpawn>();
        GR = FindObjectOfType<GetReady>();

        //BSPAWN.addBullet (1, 2);

    }

    void Update()
    {
        if (!FirstBoss.GetComponent<Enemy>().isDead() && GR.BeginTheGame == true)
        {
            LoadBullets();
        }
    }

    void LoadBullets()
    {
        for (int i = 0; i < InspectorArray.Length; i++)
        {
            int bulletID = 7;
            //0: Normal - Undeflectable
            //1: Normal - Deflectable
            //2: Offlane- Deflectable - Left
            //3: Offlane- Deflectable - Right
            //4: Offlane- Undeflectable
            //5: Split (undeflectable only)
            //6: Missile (deflectable MUST)
            //7: Empty / Silent (ada bagian di pattern yang kosong)
            //8: Ghost - Undeflectable
            if (InspectorArray[i].deflectable) { bulletID = 1; }
            else if (InspectorArray[i].undeflectable) { bulletID = 0; }
            else if (InspectorArray[i].offlaneLeft) { bulletID = 2; }
            else if (InspectorArray[i].offlaneRight) { bulletID = 3; }
            else if (InspectorArray[i].offLaneUndeflectable) { bulletID = 4; }
            else if (InspectorArray[i].split) { bulletID = 5; }
            else if (InspectorArray[i].lob) { bulletID = 6; }
            else if (InspectorArray[i].ghost) { bulletID = 8; }
            int laneID = 0;
            if (InspectorArray[i].leftLane) { laneID = 0; }
            else if (InspectorArray[i].offLeft) { laneID = 1; }
            else if (InspectorArray[i].midLane) { laneID = 2; }
            else if (InspectorArray[i].offRight) { laneID = 3; }
            else if (InspectorArray[i].rightLane) { laneID = 4; }
            bulletSpawn.addBullet(bulletID, laneID);
        }
    }
}
