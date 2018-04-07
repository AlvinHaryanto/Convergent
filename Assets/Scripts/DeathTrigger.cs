using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{

    public GameObject ship;
    public GameObject explosion;

   void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Instantiate(explosion, col.transform.position, col.transform.rotation);
            Destroy(col.gameObject);
            Destroy(ship.gameObject);
            Gameover();
        }

    }

    public void Gameover()
    {
        SceneManager.LoadScene("Gameover(Demo)");
    }
}