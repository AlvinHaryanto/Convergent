using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{

    public GameObject ship;
    public GameObject explosion;


	public static string PrevScene;

   void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            BulletMovement bMov = col.gameObject.GetComponent<BulletMovement>();
            //destroy only if is not deflecting offlane correctly
            if(!(bMov.getLaneID()==1&& bMov.getDeflectDir()==ship.GetComponent<PlayerMovement>().getPlayerDir())&&!bMov.deflecting)
            {
                Instantiate(explosion, col.transform.position, col.transform.rotation);
                Destroy(col.gameObject);
                Destroy(ship.gameObject);
				SFX.instance.PlayMampus ();
                Gameover();
            }
        }

    }

    public void Gameover()
    {
		PrevScene = SceneManager.GetActiveScene ().name;
		PlayerPrefs.SetString("Result", "game over");
		BackMusic.instance.source.mute = true; //setelah mati lagunya matiin
        SceneManager.LoadScene("Gameover(Demo)");
    }
}