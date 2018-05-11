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
            //destroy only if is not deflecting offlane correctly
            if(!(col.gameObject.GetComponent<BulletMovement>().getLaneID()==1&& col.gameObject.GetComponent<BulletMovement>().getDeflectDir()==ship.GetComponent<PlayerMovement>().getPlayerDir()))
            {
                Instantiate(explosion, col.transform.position, col.transform.rotation);
                Destroy(col.gameObject);
                Destroy(ship.gameObject);
                Gameover();
            }
        }

    }

    public void Gameover()
    {
        PlayerPrefs.SetString("Result", "Game Over");
        SceneManager.LoadScene("Gameover(Demo)");
    }
}