using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cd_LevelSelectV2 : MonoBehaviour {
    private int levelSelected=0;
    public MainMenu menuScript;
    [System.Serializable]
    public class SongList
    {
        public AudioClip audioSnippet;
        public bool easyEnable;
        public bool normalEnable;
        public bool hardEnable;
        public bool lunaticEnable;
    }

    public SongList[] songList;
    [SerializeField] Button easyButton;
    [SerializeField] Button mediumButton;
    [SerializeField] Button hardButton;
    [SerializeField] Button lunaticButton;

    private void Start()
    {
        easyButton.interactable = false;
        mediumButton.interactable = false;
        hardButton.interactable = false;
        lunaticButton.interactable = false;

    }
    public void SetSelectedLevel(int level)
    {
        levelSelected = level;
        BackMusic.instance.PlayMusic(songList[levelSelected-1].audioSnippet);
        if (songList[levelSelected - 1].easyEnable) { easyButton.interactable = true; } else { easyButton.interactable = false; }
        if (songList[levelSelected - 1].normalEnable) { mediumButton.interactable = true; } else { mediumButton.interactable = false; }
        if (songList[levelSelected - 1].hardEnable) { hardButton.interactable = true; } else { hardButton.interactable = false; }
        if (songList[levelSelected - 1].lunaticEnable) { lunaticButton.interactable = true; } else { lunaticButton.interactable = false; }
    }
    public void GoToEasy()
    {
        menuScript.LoadSceneNamed("Song" + levelSelected + "Easy");
    }
    public void GoToMedium()
    {
        menuScript.LoadSceneNamed("Song" + levelSelected + "Medium");
    }
    public void GoToHard()
    {
        menuScript.LoadSceneNamed("Song" + levelSelected + "Hard");
    }
    public void GoToLunatic()
    {
        menuScript.LoadSceneNamed("Song" + levelSelected + "Lunatic");
    }
}
