using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{

    public GameObject ship;
    public GameObject explosion;

    private void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Instantiate(explosion, col.transform.position, col.transform.rotation);
            Destroy(col.gameObject);
            Destroy(ship.gameObject);
        }
    }
}