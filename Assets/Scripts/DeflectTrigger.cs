using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectTrigger : MonoBehaviour {
    public PlayerMovement player;
	public BulletSpawn bspawn;
	int x;

    private void OnTriggerStay(Collider col)
    {
		
		if (Input.GetKeyDown(KeyCode.Space))
        {
			if (col.gameObject.tag == "Bullet"&&col.gameObject.GetComponent<BulletMovement>().deflectable) {
                player.plyrAnim.Play("ShipDeflect");
                Debug.Log("Deflected");
                col.gameObject.SendMessage("SetDeflecting",true);
			}
        }

    }

	/*void Update() {
		x = bspawn.GetChooser();
	}*/
}
