using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour {

    public Slider SliderSFX, SliderBGM;
    
    void Start()
    {
        SliderSFX.value = SFX.instance.GetVolume();
        SliderBGM.value = BackMusic.instance.GetVolume();
    }

    void Update()
    {
        SFX.instance.SetVolume(SliderSFX.value);
        BackMusic.instance.SetVolume(SliderBGM.value);
    }
}
