using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour {
	[System.Serializable]
	public class SongList
	{
		public Sprite coverImage;
		public AudioClip audioSnippet;
		public bool easyEnable;
		public bool normalEnable;
		public bool hardEnable;
		public bool LunaticEnable;
	}

	public SongList[] songList;
    public Cd_CoverAnimation coverAnimHandler;
    public float WaitAnimation;

	public Button Easy, Medium, Hard, Lunatic, NextSong, PrevSong;
	public AudioClip Song1, Song2;
	public Image CoverSong1, CoverSong2;

	int Flag; //Kalau lagu 1 flag 1, lagu 2 flag 2. 
	void Start() {
		PreviewSong1 ();
	}

	public void GoEasy() {
		SceneManager.LoadScene ("Song"+(Flag+1)+"Easy");
	}

	public void GoMedium() {
		SceneManager.LoadScene ("Song"+(Flag+1)+"Medium");
	}

	public void GoHard() {
		SceneManager.LoadScene ("Song"+(Flag+1)+"Hard");
	}

	public void GoLunatic() {
		SceneManager.LoadScene ("Song"+(Flag+1)+"Lunatic");
	}

	public void PreviewSong1() {
		Lunatic.interactable = false; //You can't play Song 1 on Lunatic Difficulty
		Easy.interactable = true; //If u switch to song2, and go back to song1 u can access back ur easy choice
		Flag = 0;

		//BackMusic.instance.PlayMusic (Song1);
		StartCoroutine(PlayPreview(Song1));
		/*PrevSong.gameObject.SetActive (false);
		NextSong.gameObject.SetActive (true);*/

		/*CoverSong1.gameObject.SetActive (true);
		CoverSong2.gameObject.SetActive (true);*/
	}

	public void PreviewSong2() {
		Lunatic.interactable = true;
		Easy.interactable = false;
		Flag = 1;

		//BackMusic.instance.PlayMusic (Song2);
		StartCoroutine(PlayPreview(Song2));
		/*PrevSong.gameObject.SetActive (true);
		NextSong.gameObject.SetActive (false);*/

		/*CoverSong1.gameObject.SetActive (false);
		CoverSong2.gameObject.SetActive (true);*/
	}
	private void selectSong(){
		//gambar, lagu

		StartCoroutine(PlayPreview(songList[Flag].audioSnippet));
        //StartCoroutine(DelayedCoverSwitch());
        /*
        CoverSong1.sprite = songList[Flag].coverImage;
        if (Flag + 1 >= songList.Length)
        {
            CoverSong2.sprite = songList[0].coverImage;
        }
        else
        {
            CoverSong2.sprite = songList[Flag + 1].coverImage;
        }*/

        Easy.interactable = songList [Flag].easyEnable;
		Medium.interactable = songList [Flag].normalEnable;
		Hard.interactable = songList [Flag].hardEnable;
		Lunatic.interactable = songList [Flag].LunaticEnable;

	}
	public void nextSong(){
		//<===ANIMATION OF SWITCHING COVER ARTS== NEXT COVER
		//antisipasi loop
		increaseFlag();
		selectSong ();
        coverAnimHandler.SetCoverSwitching(1);
	}
	public void prevSong(){
		//<===ANIMATION OF SWITCHING COVER ARTS== NEXT COVER
		//antisipasi loop
		decreaseFlag();
		selectSong ();
        coverAnimHandler.SetCoverSwitching(-1);

    }
	private void decreaseFlag(){
		Flag--;
		if(Flag<0){
			Flag = songList.Length - 1;
		}
	}
	private void increaseFlag(){
		Flag++;
		if(Flag>songList.Length-1){
			Flag = 0;
		}
	}
	IEnumerator PlayPreview(AudioClip MusicClip) {
		BackMusic.instance.source.mute = true;
		turnOffButtons();

		yield return new WaitForSeconds (WaitAnimation);

		turnOnButtons ();
		BackMusic.instance.source.mute = false;
		BackMusic.instance.PlayMusic (MusicClip);
	}
    IEnumerator DelayedCoverSwitch()
    {
        yield return new WaitForSeconds(WaitAnimation);

        CoverSong1.sprite = songList[Flag].coverImage;
        if (Flag + 1 >= songList.Length)
        {
            CoverSong2.sprite = songList[0].coverImage;
        }
        else
        {
            CoverSong2.sprite = songList[Flag + 1].coverImage;
        }
    }
    public void switchCover()
    {
        CoverSong1.sprite = songList[Flag].coverImage;
        if (Flag + 1 >= songList.Length)
        {
            CoverSong2.sprite = songList[0].coverImage;
        }
        else
        {
            CoverSong2.sprite = songList[Flag + 1].coverImage;
        }
    }
	private void turnOffButtons(){
		Easy.gameObject.SetActive (false);
		Medium.gameObject.SetActive (false);
		Hard.gameObject.SetActive (false);
		Lunatic.gameObject.SetActive (false);
        NextSong.gameObject.SetActive(false);
        PrevSong.gameObject.SetActive(false);
    }

	private void turnOnButtons(){
		//<<ADD ANIMATION OF BUTTON APPEARING HERE!!!
		Easy.gameObject.SetActive (true);
		Medium.gameObject.SetActive (true);
		Hard.gameObject.SetActive (true);
		Lunatic.gameObject.SetActive (true);
        NextSong.gameObject.SetActive(true);
        PrevSong.gameObject.SetActive(true);
    }
}
