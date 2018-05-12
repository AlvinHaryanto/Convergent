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
        BulletMovement tempBullet = col.gameObject.GetComponent<BulletMovement>();
        //deflect off-lane if movement direction is correct
        if (tempBullet.getLaneID()==1&&tempBullet.deflectable){
			if(tempBullet.getDeflectDir()==player.getPlayerDir()){
				//Kalau inputan player (player dir, liat di script playermovement) sesuai dengan
				//input yang diminta (bullet movement.deflectdir) --> deflect
				player.plyrAnim.Play("ShipDeflect");
				col.gameObject.SendMessage("SetDeflecting",true);
				SFX.instance.source.PlayOneShot(deflectClip);
			}
		}
        else
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
