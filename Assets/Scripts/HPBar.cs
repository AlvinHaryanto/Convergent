using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour {


	public Slider EnemyHP;

	Enemy EnemyScript;

	void Start() {
		EnemyScript = FindObjectOfType<Enemy> ();
	}

	void Update() {
		EnemyHP.value = (EnemyScript.EnemyHP / EnemyScript.maxHp);
		Debug.Log (EnemyScript.EnemyHP + ", " + EnemyScript.maxHp);
		//Debug.Log ("Enemy hp is " + EnemyScript.EnemyHP + ", Value = " + EnemyHP.value);
	}
}
