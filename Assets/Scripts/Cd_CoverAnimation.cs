using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cd_CoverAnimation : MonoBehaviour {
    public SelectLevel selectLevel;
    public Animator animator;
    public GameObject cover1,cover2;
    public void Cover1First()
    {
        cover1.transform.SetSiblingIndex(1);
    }
    public void Cover2First()
    {
        cover2.transform.SetSiblingIndex(1);
    }
    public void SetCoverSwitching(int newState)
    {
        animator.SetInteger("coverSwitching",newState);
    }
    public void updateCovers()
    {
        selectLevel.switchCover();
    }
}
