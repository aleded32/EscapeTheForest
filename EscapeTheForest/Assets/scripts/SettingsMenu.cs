using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    public GameObject music;
    public Button musicButton;
    public Sprite MusicButtonImageOff;
    public Sprite MusicButtonImageOn;
    public Sprite newhighlightedSpriteOff;
    public Sprite newhighlightedSpriteOn;
    public bool isMusicOff = false;
    public GameObject soundFX;
    public Button soundFXButton;
    public Sprite soundFXButtonImageOff;
    public Sprite soundFXButtonImageOn;
    public Sprite soundFxnewhighlightedSpriteOff;
    public Sprite soundFxnewhighlightedSpriteOn;
    public bool isSoundFXOff = false;
    public GameObject Audio;
    public GameObject PauseMenuUI;
    public GameObject settingMenuUI;

    public void MusicChange()
    {

        if (isMusicOff == false)
        {
            music.GetComponent<Image>().sprite = MusicButtonImageOff;
            SpriteState MusicOffSs = new SpriteState();
            MusicOffSs.highlightedSprite = newhighlightedSpriteOff;
            musicButton.spriteState = MusicOffSs;
            isMusicOff = true;
            Audio.GetComponent<AudioSource>().volume = 0.0f;
            
        }
        else if(isMusicOff == true)
        {
            music.GetComponent<Image>().sprite = MusicButtonImageOn;
            SpriteState MusicOffSs = new SpriteState();
            MusicOffSs.highlightedSprite = newhighlightedSpriteOn;
            musicButton.spriteState = MusicOffSs;
            isMusicOff = false;
            Audio.GetComponent<AudioSource>().volume = 0.033f;
        }
        
    }

    public void soundFXChange()
    {
        if (isSoundFXOff == false)
        {
            soundFX.GetComponent<Image>().sprite = soundFXButtonImageOff;
            SpriteState soundFXOffSs = new SpriteState();
            soundFXOffSs.highlightedSprite = soundFxnewhighlightedSpriteOff;
            soundFXButton.spriteState = soundFXOffSs;
            isSoundFXOff = true;
           
        }
        else if (isSoundFXOff == true)
        {
            soundFX.GetComponent<Image>().sprite = soundFXButtonImageOn;
            SpriteState soundFXOffSs = new SpriteState();
            soundFXOffSs.highlightedSprite = soundFxnewhighlightedSpriteOn;
            soundFXButton.spriteState = soundFXOffSs;
            isSoundFXOff = false;
        }
    }

    public void backButton()
    {
        PauseMenuUI.SetActive(true);
        settingMenuUI.SetActive(false);
    }
 
}
