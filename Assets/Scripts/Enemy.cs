using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
	
	public float EnemyHP = 3; 

    public float speed = 10f;

    public Transform target;
    private int wavepointIndex = 0;
    
	public float maxHp;
    bool canDeflect;
    private void Start()
    {
        target = Waypoints.points[0];
		maxHp = EnemyHP;
        //canDeflect = GameObject.Find("Bullet").GetComponent<BulletMovement>().GetDeflecting();
    }
    private void FixedUpdate()
    {
        Vector3 dir = target.position - transform.position;
        
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            //GetNextWaypoint();
            transform.Translate(dir.normalized * 0, Space.World);
        }
        else transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

    }

    void GetNextWaypoint()
    {
        //if (wavepointIndex >= Waypoints.points.Length - 1)
        // {
            //transform.Translate(dir.normalized * 0);
        //    return;
        //}
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];

    }
    public void damagedBy(int x)
    {
        EnemyHP -= x;
        if (EnemyHP <= 0)
        {
            //game over script from death trigger
            //SHOULD WAIT 3 SECONDS
			SFX.instance.PlayMenang();

			GameOver();
        }
    }

    void GameOver()
    {
        PlayerPrefs.SetString("Result","victory!");
        SceneManager.LoadScene("Gameover(Demo)");
    }
    /*void OnTriggerStay(Collider col)
    {
        
        if (col.gameObject.tag == "Bullet")
        {
            Instantiate(explosion, col.transform.position, col.transform.rotation);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }*/

	void Update() {
		//Debug.Log ("Enemy hp is " + EnemyHP);
	}

	public bool isDead() {
		if (EnemyHP >= 0) {
			return false;
		} else {
			return true;
		}
	}

   

}

