using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectTrigger : MonoBehaviour {
    void Start() {
	}

    private void OnTriggerStay(Collider col)
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
			if (col.gameObject.tag == "Bullet") {

                Debug.Log("Deflected");
                col.gameObject.SendMessage("SetDeflecting",true);
			}
        }

    }
}
