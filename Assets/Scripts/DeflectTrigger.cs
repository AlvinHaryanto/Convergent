﻿using System.Collections;
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
            player.plyrAnim.Play("ShipDeflect");
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
        if (tempBullet&&(tempBullet.getLaneID()==1|| tempBullet.getLaneID() == 3) &&tempBullet.deflectable && !tempBullet.deflecting)
        {
			if(tempBullet.getDeflectDir()==player.getPlayerDir()){
                //Kalau inputan player (player dir, liat di script playermovement) sesuai dengan
                //input yang diminta (bullet movement.deflectdir) --> deflect

                col.gameObject.SendMessage("SetDeflecting", true);
                SFX.instance.source.PlayOneShot(deflectClip);
                tempBullet.DeflectCoord(2);
            }
		}
        else
        if (curDuration>0&&col.gameObject.tag == "Bullet" && col.gameObject.GetComponent<BulletMovement>().deflectable && !col.gameObject.GetComponent<BulletMovement>().deflecting)
        {
            col.gameObject.SendMessage("SetDeflecting", true);
            player.plyrAnim.Play("ShipDeflect");
            tempBullet.DeflectCoord(2);
            SFX.instance.source.PlayOneShot(deflectClip);
        }
    }

	/*void Update() {
		x = bspawn.GetChooser();
	}*/
}
