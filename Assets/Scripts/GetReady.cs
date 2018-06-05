using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetReady : MonoBehaviour {

	public Text GetReadyText;
	public bool BeginTheGame; //ini nanti berhubungan sama timer sebelum mulai + music nya
	public float preparationTime; // berapa lama waktu delay nya
	private float temp;

	void Start() {
		preparationTime += 2f;
		temp = preparationTime;
	}

	void Update() {
		if (preparationTime > 1) {
			preparationTime -= Time.deltaTime;
			if (preparationTime <= temp - 1f) {
				GetReadyText.fontSize = 140;
				GetReadyText.text = ((int)preparationTime).ToString ();
			}

		}else {
			preparationTime = 0;
			GetReadyText.fontSize = 65;
			GetReadyText.text = "START!";

			StartCoroutine (WaitToDestroy());
			BeginTheGame = true;
		}

		Debug.Log ("Preparation time is : " + preparationTime);
	}

	IEnumerator WaitToDestroy() {
		yield return new WaitForSeconds (0.5f);
		Destroy (GetReadyText.gameObject);
	}
}
