using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cd_DeleteData : MonoBehaviour {

	public void deleteAllData()
    {
        PlayerPrefs.DeleteAll();
    }
    public void activateObject(GameObject box)
    {
        box.SetActive(true);
    }
    public void deactivateObject(GameObject box)
    {
        box.SetActive(false);
    }
}
