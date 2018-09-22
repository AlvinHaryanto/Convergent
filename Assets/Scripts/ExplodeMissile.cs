using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeMissile : MonoBehaviour
{


    Rigidbody rb;
    public Animator rocketAnim;
    public BulletMovement rocketMain;
    public GameObject bullet;
    public GameObject ship;
    
    private float PO;

    bool deflecting;
    private float timer;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ship = GameObject.Find("Player");
        PO = ship.transform.position.z-2;
        //rb.velocity = new Vector3(0f, 0f, 1 * speed * Time.deltaTime);
        deflecting = false;
    }


    void Update()
    {
        Debug.Log("Anim speed is "+rocketAnim.speed);
        if (transform.position.z <= PO)
        {
            Instantiate(bullet, ship.transform.position,transform.rotation);
            GameObject tempBoom = Instantiate(rocketMain.explosion,transform.position,transform.rotation);
            tempBoom.transform.localScale *= 5;
            DestroyObject(this.gameObject);
        }
        if (rocketMain.deflecting)
        {
            rocketAnim.SetBool("Deflecting", true);
        }
    }
    
    /* if (bullet.transform.position.z < PO)
     {

         if (deflecting == false)
         {
             //handle at death collision of Ship

             //rb.velocity = new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
             //Debug.Log("deflecting false kintil");
             //
         }
         else
         {
             Debug.Log("true qntl");
         }
     }

     /*if(GetComponent<DeflectTrigger>  false) //cara triggernya deflect
     {
         {
             if (bullet.position)
             {
                 //deflect script sebelah
             }
         }
     }*/

}

