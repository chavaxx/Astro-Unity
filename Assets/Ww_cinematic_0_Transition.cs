using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ww_cinematic_0_Transition : MonoBehaviour{

    //public AkEvent NextWwiseEvent_wTimer_cinem0;
    public bool jumpable = false;

    void Start(){
        StartCoroutine(Clickable());
        StartCoroutine(EndTimer());
    }

    void Update(){
        if (Input.anyKey && jumpable){
            Debug.Log("Stopped long cinematic with input");
            StopAllCoroutines();
            //NextWwiseEvent_wTimer_cinem0.HandleEvent(gameObject);
            jumpable = false;
        }
    }

    IEnumerator EndTimer(){
        yield return new WaitForSeconds(29f);
        //NextWwiseEvent_wTimer_cinem0.HandleEvent(gameObject);
        Debug.Log("Stopped long cinematic with timer = 0");
        jumpable = false;

    }

    IEnumerator Clickable(){
        yield return new WaitForSeconds(21.2f);
        Debug.Log("Long cinematic jumpable");
        jumpable = true;
    }
}