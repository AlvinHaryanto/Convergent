using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public float speed;
    Rigidbody rb;

    public bool deflecting;
    public Transform target;
    public float rotateSpeed = 200f;
    public GameObject explosion;

    private GameObject EnemyTarget;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        EnemyTarget = GameObject.Find("Enemy");
        if (EnemyTarget)
        {
            target = EnemyTarget.transform;
        }
        else
        {
            EnemyTarget = null;
        }


        deflecting = false;

    }
    void Update()
    {
        if (deflecting == false)
        {
            rb.velocity = new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
        }
        else if (deflecting == true && EnemyTarget == null)
        {
            //transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
            transform.rotation = new Quaternion(0, 0, 180, 0);
            rb.velocity = new Vector3(0f, 0f, speed * Time.deltaTime);

        }



        if (transform.position.z <= -10 || transform.position.z >= 70f)
        {
            Destroy(gameObject);
        }


    }

    public void SetDeflecting(bool x)
    {
        deflecting = x;
    }
    public bool GetDeflecting()
    {
        return deflecting;
    }

    void FixedUpdate()
    {
        if (deflecting && EnemyTarget)
        {
            //HOMMING SCRIPT :
            Vector3 direction = target.position - rb.position;
            direction.Normalize();
            transform.LookAt(target);
            //Vector3 rotateAmount = Vector3.Cross(transform.forward, direction);
            // rb.angularVelocity = rotateAmount * rotateSpeed;
            rb.velocity = transform.forward * speed * Time.deltaTime;

            /*Vector3 direction = (Vector3)target.position - rb.position;
			direction.Normalize ();
			float rotateAmount = Vector3.Cross (direction, transform.up).z;
			rb.angularVelocity = -rotateAmount * rotateSpeed;
			rb.velocity = transform.up * speed;*/

        }


    }

    void OnTriggerStay(Collider col)
    {
        if (deflecting == true && col.gameObject.tag == "Enemy")
        {
            Instantiate(explosion, col.transform.position, col.transform.rotation);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
