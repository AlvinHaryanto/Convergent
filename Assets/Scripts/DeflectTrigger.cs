using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectTrigger : MonoBehaviour {
    public PlayerMovement player;
	public BulletSpawn bspawn;
    public float onDuration;
    public float curDuration = 0;
	int x;

    public AudioClip deflectClip;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            curDuration = onDuration;
        }
        if (curDuration > 0)
        {
            curDuration -= Time.deltaTime;
        }
    }
    private void OnTriggerStay(Collider col)
    {
        BulletMovement tempBullet = col.gameObject.GetComponent<BulletMovement>();
        //deflect off-lane if movement direction is correct
        if (tempBullet.getLaneID()==1&&tempBullet.deflectable && !col.gameObject.GetComponent<BulletMovement>().deflecting)
        {
			if(tempBullet.getDeflectDir()==player.getPlayerDir()){
				//Kalau inputan player (player dir, liat di script playermovement) sesuai dengan
				//input yang diminta (bullet movement.deflectdir) --> deflect
				player.plyrAnim.Play("ShipDeflect");
				col.gameObject.SendMessage("SetDeflecting",true);
				SFX.instance.source.PlayOneShot(deflectClip);
			}
		}
        else
        if (curDuration>0&&col.gameObject.tag == "Bullet" && col.gameObject.GetComponent<BulletMovement>().deflectable && !col.gameObject.GetComponent<BulletMovement>().deflecting)
        {
            player.plyrAnim.Play("ShipDeflect");
            col.gameObject.SendMessage("SetDeflecting", true);
            SFX.instance.source.PlayOneShot(deflectClip);
        }
    }

	/*void Update() {
		x = bspawn.GetChooser();
	}*/
}
