using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{

    public GameObject ship;

    private void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Destroy(ship.gameObject);
        }
    }
}