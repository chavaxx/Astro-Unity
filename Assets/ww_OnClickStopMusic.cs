using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ww_OnClickStopMusic : MonoBehaviour {

    public void StopMusic() {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Gameplay/startGame");
        /*MainMenuManager.instance.mainMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        MainMenuManager.instance.mainMusic.release();*/
        Debug.Log("FM Stopped Music with color buttons");
    }
}