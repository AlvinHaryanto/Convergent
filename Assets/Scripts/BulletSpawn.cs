using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    private List<int> BulletList = new List<int>();
    private List<int> LaneList = new List<int>();
    private int finalIndex = 0;
    //calls the property of the bullet of index N

    private int currInterval = 0;
    public GameObject bullet;
    public GameObject undeflectable;
    public GameObject offlane;
    public GameObject offlaneUndeflectable;
    public GameObject split;
    public GameObject missile;
	//public GameObject EmptyBullet;
    public float timer;

    Vector3 location;

    private float offlaneLeft, offlaneRight;
    int DeflectDir;
    int BulletChooser;
    float count;
    GameObject tempBullet;

    private void Start()
    {
        location = new Vector3(0, 0, 67.59f);
        count = 1;

        offlaneLeft = -3.3f;
        offlaneRight = 3.48f;

        //initialize bullet list here
        //bullet ID legend:
        //0: Normal - Undeflectable
        //1: Normal - Deflectable
        //2: Offlane- Deflectable - Left
        //3: Offlane- Deflectable - Right
        //4: Offlane- Undeflectable
        //5: Split (undeflectable only)
        //6: Missile (deflectable MUST)
		//7: Empty / Silent (ada bagian di pattern yang kosong)

        //lane ID legend;
        //0: left
        //1: offlane left
        //2: mid
        //3: offlane right
        //4: right
        
		/*addBullet(0, 2);
        addBullet(0, 4);
        addBullet(0, 0);
        addBullet(0, 2);
        addBullet(1, 2);
        addBullet(3, 1);
        addBullet(4, 3);
        addBullet(3, 3);
        addBullet(1, 4);
        addBullet(5, 2);
        addBullet(5, 0);
        addBullet(5, 2);
        addBullet(6, 2);
        addBullet(6, 4);*/
        
    }

    public int GetChooser()
    {
        return BulletChooser;
    }

    void Update()
    {
        //Debug.Log (count);
        count += Time.deltaTime;
        
        if (count >= timer)
        {
            switch (LaneList[currInterval])
            {
                case 0:
                    location.x = -7.27f;
                    break;
                case 1:
                    location.x = offlaneLeft;
                    break;
                case 2:
                    location.x = 0f;
                    break;
                case 3:
                    location.x = offlaneRight;
                    break;
                case 4:
                    location.x = 7.27f;
                    break;
            }
            switch (BulletList[currInterval])
            {
                case 0:
                    tempBullet = Instantiate(undeflectable, location, bullet.transform.rotation);
                    break;
                case 1:
                    tempBullet = Instantiate(bullet, location, bullet.transform.rotation);
                    break;
                case 2:
                    tempBullet = Instantiate(offlane, location, bullet.transform.rotation);
                    tempBullet.GetComponent<BulletMovement>().setLaneID(1);
                    tempBullet.GetComponent<BulletMovement>().setDeflectDir(0);
                    //lane ID indicates offlane
                    //deflect dir sets the correct deflection direction
                    break;
                case 3:
                    tempBullet = Instantiate(offlane, location, bullet.transform.rotation);
                    tempBullet.GetComponent<BulletMovement>().setLaneID(1);
                    tempBullet.GetComponent<BulletMovement>().setDeflectDir(1);
                    tempBullet.GetComponent<BulletMovement>().Model.transform.localScale = new Vector3(-1 * tempBullet.GetComponent<BulletMovement>().Model.transform.localScale.x, tempBullet.GetComponent<BulletMovement>().Model.transform.localScale.y, tempBullet.GetComponent<BulletMovement>().Model.transform.localScale.z);
                    break;
                case 4:
                    tempBullet = Instantiate(offlaneUndeflectable, location, bullet.transform.rotation);
                    tempBullet.GetComponent<BulletMovement>().setLaneID(1);
                    break;
                case 5:
                    tempBullet = Instantiate(split, location, bullet.transform.rotation);
                    break;
                case 6:
                    tempBullet = Instantiate(missile, location, bullet.transform.rotation);
                    break;
				case 7:
					//EMPTY BULLET
					break;

			
				
            }
            /*
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

            */
            currInterval++;
            if (currInterval >= finalIndex)
            {
                currInterval = 0;
            }
            count = 1;
        }



    }//end of update
    public void addBullet(int bulletID, int laneID)
    {
        BulletList.Add(bulletID);
        LaneList.Add(laneID);
        finalIndex++;
    }


}
