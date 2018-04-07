using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectTrigger : MonoBehaviour {
    public PlayerMovement player;
	public BulletSpawn bspawn;
	int x;

    public AudioClip deflectClip;

    private void OnTriggerStay(Collider col)
    {
		
		if (Input.GetKey(KeyCode.Space))
        {
			if (col.gameObject.tag == "Bullet"&&col.gameObject.GetComponent<BulletMovement>().deflectable) {
                player.plyrAnim.Play("ShipDeflect");
                Debug.Log("Deflected");
                col.gameObject.SendMessage("SetDeflecting",true);

                SFX.instance.source.PlayOneShot(deflectClip);
            }
        }

    }

	/*void Update() {
		x = bspawn.GetChooser();
	}*/
}
