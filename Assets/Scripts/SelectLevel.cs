﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour {

	public Button Easy, Medium, Hard, Lunatic, NextSong, PrevSong;
	public AudioClip Song1, Song2;
	public Image CoverSong1, CoverSong2;

	int Flag; //Kalau lagu 1 flag 1, lagu 2 flag 2. 
	void Start() {
		PreviewSong1 ();
	}

	public void GoEasy() {
		if (Flag == 1) {
			SceneManager.LoadScene ("Song1Easy");
		} else if (Flag == 2) {
			// .....
		}
	}

	public void PreviewSong1() {
		Lunatic.interactable = false; //You can't play Song 1 on Lunatic Difficulty
		Easy.interactable = true; //If u switch to song2, and go back to song1 u can access back ur easy choice
		Flag = 1;

		//BackMusic.instance.PlayMusic (Song1);
		StartCoroutine(PlayPreview(Song1));
		PrevSong.gameObject.SetActive (false);
		NextSong.gameObject.SetActive (true);

		CoverSong1.gameObject.SetActive (true);
		CoverSong2.gameObject.SetActive (false);
	}

	public void PreviewSong2() {
		Lunatic.interactable = true;
		Easy.interactable = false;
		Flag = 2;

		//BackMusic.instance.PlayMusic (Song2);
		StartCoroutine(PlayPreview(Song2));
		PrevSong.gameObject.SetActive (true);
		NextSong.gameObject.SetActive (false);

		CoverSong1.gameObject.SetActive (false);
		CoverSong2.gameObject.SetActive (true);
	}

	IEnumerator PlayPreview(AudioClip MusicClip) {
		BackMusic.instance.source.mute = true;
		yield return new WaitForSeconds (0.8f);
		BackMusic.instance.source.mute = false;
		BackMusic.instance.PlayMusic (MusicClip);
	}

}
