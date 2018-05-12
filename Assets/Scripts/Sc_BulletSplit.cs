using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_BulletSplit : MonoBehaviour {
    Rigidbody rb;
    public float speed = 4900;
    public float playerZ = -1.06f;
    //REFER TO THE PLAYER OBJECT IN THE SCENE
    public GameObject bullet;
    private float splitPercent = 0.75f;
    private float zDistance;
    private float initZDistance=0;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
        zDistance = transform.position.z - playerZ;
        if (initZDistance == 0)
        {
            initZDistance = zDistance;
        }
        // (bullet.transform.position.z <= playerZ)
        //    Instantiate(bullet, playerposition)
        if (zDistance < (1-splitPercent) * initZDistance)
        {

            Instantiate(bullet, transform.position+new Vector3(7.27f,0,0), bullet.transform.rotation);
            Instantiate(bullet, transform.position + new Vector3(-7.27f, 0, 0), bullet.transform.rotation);
            //7.27 is distance between lane, REFER BACK TO BULLET SPAWN
            Destroy(gameObject);
        }
    }
}
