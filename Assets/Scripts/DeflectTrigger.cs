using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectTrigger : MonoBehaviour {
    public PlayerMovement player;
    void Start() {
	}

    private void OnTriggerStay(Collider col)
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            player.plyrAnim.Play("ShipDeflect");
            if (col.gameObject.tag == "Bullet") {
                Debug.Log("Deflected");
                col.gameObject.SendMessage("SetDeflecting",true);
			}
        }

    }
}
