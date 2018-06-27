using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour {

	public Button Easy, Medium, Hard, Lunatic, NextSong, PrevSong;
	public AudioClip Song1, Song2;
	public Image CoverSong1, CoverSong2;

	void Start() {
		PreviewSong1 ();
	}

	public void PreviewSong1() {
		Lunatic.interactable = false; //You can't play Song 1 on Lunatic Difficulty
		Easy.interactable = true; //If u switch to song2, and go back to song1 u can access back ur easy choice

		BackMusic.instance.PlayMusic (Song1);
		PrevSong.gameObject.SetActive (false);
		NextSong.gameObject.SetActive (true);

		CoverSong1.gameObject.SetActive (true);
		CoverSong2.gameObject.SetActive (false);
	}

	public void PreviewSong2() {
		Lunatic.interactable = true;
		Easy.interactable = false;

		BackMusic.instance.PlayMusic (Song2);
		PrevSong.gameObject.SetActive (true);
		NextSong.gameObject.SetActive (false);

		CoverSong1.gameObject.SetActive (false);
		CoverSong2.gameObject.SetActive (true);
	}

}
