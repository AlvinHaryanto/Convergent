﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBullet : MonoBehaviour {
    bool startTrans = false;
    Rigidbody rb;
    public Animator rocketAnim;
    
    public GameObject bullet;
   
    public GameObject ship;
    public float TransMult;
    public float PO;
    public float PO2;

    bool deflecting;
    private float timer;
    private Color OriginColor;
    

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ship = GameObject.Find("Player");
        OriginColor = GetComponent<MeshRenderer>().material.color;


    
       


        //rb.velocity = new Vector3(0f, 0f, 1 * speed * Time.deltaTime);
        deflecting = false;
    }


    void Update()
    {
        if(transform.position.z <= PO2)
        {
            bullet.GetComponent<MeshRenderer>().material.color = OriginColor;
            startTrans = false;
        }else if (transform.position.z <= PO)
        {
            startTrans = true;
        }
        if (startTrans)
        {
            bullet.GetComponent<MeshRenderer>().material.color = new Color(OriginColor.r,OriginColor.g,OriginColor.b, bullet.GetComponent<MeshRenderer>().material.color.a - Time.deltaTime * TransMult);
            
        }
        /*if (rocketMain.deflecting)
        {
            //rocketAnim.SetBool("Deflecting", true);
        }
        */
    }

}