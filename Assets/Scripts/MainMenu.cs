using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Exit!!");
            Application.Quit();
        }
    }

    /*public void PlayGame()
    {
        SceneManager.LoadScene("Song1Easy");
    }*/

    public void QuitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void Retry()
    {
		SceneManager.LoadScene(DeathTrigger.PrevScene);
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("Mainmenu(Demo)");
    }

    public void LoadSceneNamed(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void ToOptions()
    {
        SceneManager.LoadScene("Options");
    }

	public void ToSelectLevel() {
		SceneManager.LoadScene("SelectLevel");
	}
    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
    }

    public void TestCompletion1()
    {
        for (int i = 0; i < 4; i++)
        {
            PlayerPrefs.SetInt("Song" + (i + 1) + "Easy" + "complete", 1);
            PlayerPrefs.SetInt("Song" + (i + 1) + "Medium" + "complete", 1);
            PlayerPrefs.SetInt("Song" + (i + 1) + "Hard" + "complete", 1);
            PlayerPrefs.SetInt("Song" + (i + 1) + "Lunatic" + "complete", 1);
        }
    }
    public void TestCompletion2()
    {
        PlayerPrefs.SetInt("song5lock", 1);
    }
}
