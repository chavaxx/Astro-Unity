using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fmod_mixerStart : MonoBehaviour
{
    // Start is called before the first frame update
  
    bool audioResumed = false;
    public GameObject fmod_load_MasterBank;

    private void Awake()
    {
        StartCoroutine(EndTimer());

    }

    IEnumerator EndTimer()
    {
        yield return new WaitForSeconds(0.5f);
        if (!audioResumed)
        {
            var result = FMODUnity.RuntimeManager.CoreSystem.mixerSuspend();
            Debug.Log(result);
            result = FMODUnity.RuntimeManager.CoreSystem.mixerResume();
            Debug.Log(result);
            audioResumed = true;

        }
        fmod_load_MasterBank.SetActive(true);
        Debug.Log("Soundbank Loaded");
    }   
    
}