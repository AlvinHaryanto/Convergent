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

    public void PlayGame()
    {
        SceneManager.LoadScene("TryOut");
    }

    public void QuitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene("TryOut");
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("Mainmenu(Demo)");
    }

    public void LoadSceneNamed(string name)
    {
        SceneManager.LoadScene(name);
    }

}
