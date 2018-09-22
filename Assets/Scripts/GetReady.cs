using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GetReady : MonoBehaviour {

	public Text GetReadyText;
	public bool BeginTheGame; //ini nanti berhubungan sama timer sebelum mulai + music nya
	public float preparationTime=3; // berapa lama waktu delay nya

	void Start()
    {
        PlayerPrefs.SetString("LastLevelPlayed", SceneManager.GetActiveScene().name);
        StartCoroutine(CountDown());
	}
    IEnumerator CountDown()
    {
        for(int i=0;i<3;i++)
        {
            GetReadyText.fontSize = 160;
            GetReadyText.text = ((int)(3-i)).ToString();
            yield return new WaitForSeconds(1f);
        }
        GetReadyText.fontSize = 75;
        GetReadyText.text = "START!";
        StartCoroutine(WaitToDestroy());
        BeginTheGame = true;
    }
	IEnumerator WaitToDestroy() {
		yield return new WaitForSeconds (0.5f);
		Destroy (GetReadyText.gameObject);
	}
}
