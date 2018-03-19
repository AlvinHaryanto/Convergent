using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public float speed;
    Rigidbody rb;

    public bool deflecting;

    public float HommingSpeed = 5f;
    public Transform target;
    public float rotateSpeed = 200f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        deflecting = false;
        target = GameObject.Find("Enemy").transform;
    }
    void Update()
    {
        rb.velocity = new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
        if (transform.position.z <= -10)
        {
            Destroy(gameObject);
        }

        if (deflecting == true)
        {
            Debug.Log("deflecting is true what the fuck");
        }
    }

    public void SetDeflecting(bool x)
    {
        deflecting = x;
    }

    void FixedUpdate()
    {
        if (deflecting == true)
        {
            //HOMMING SCRIPT :
            Vector3 direction = target.position - rb.position;
            direction.Normalize();
            Vector3 rotateAmount = Vector3.Cross(transform.forward, direction);
            rb.angularVelocity = rotateAmount * rotateSpeed;
            rb.velocity = transform.forward * HommingSpeed;

            /*Vector3 direction = (Vector3)target.position - rb.position;
			direction.Normalize ();
			float rotateAmount = Vector3.Cross (direction, transform.up).z;
			rb.angularVelocity = -rotateAmount * rotateSpeed;
			rb.velocity = transform.up * speed;*/

        }
    }
}
