using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBullet : MonoBehaviour {
    bool startTrans = false;
    Rigidbody rb;
    
    public GameObject bullet;
   
    public GameObject ship;
    public float TransMult;
    public float PO;
    public float PO2;

    bool deflecting;
    private float timer;
    private Color OriginColor;
    private Material mesh;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ship = GameObject.Find("Player");
        mesh = transform.GetChild(0).GetComponent<MeshRenderer>().material;
        OriginColor = mesh.color;


    
       


        //rb.velocity = new Vector3(0f, 0f, 1 * speed * Time.deltaTime);
        deflecting = false;
    }


    void Update()
    {
        if(transform.position.z <= PO2)
        {
            mesh.color = OriginColor;
            startTrans = false;
        }else if (transform.position.z <= PO)
        {
            startTrans = true;
        }
        if (startTrans)
        {
            mesh.color = new Color(OriginColor.r,OriginColor.g,OriginColor.b,((transform.position.z-PO2)/(PO-PO2)));
        }
        /*if (rocketMain.deflecting)
        {
            //rocketAnim.SetBool("Deflecting", true);
        }
        */
    }

}
