using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightBehavior : MonoBehaviour
{
    [SerializeField] GameObject flashlight;
    [SerializeField] bool flashlightState = true;
    [SerializeField] int clicksToFix = 1;

    public void OnClick(){
        if(flashlight.activeSelf == false){ return; }
        if(clicksToFix > 0){
            Debug.Log($"clicks left {clicksToFix}");
            clicksToFix -= 1;
            return;
        }

        flashlightState = flashlightState ? false : true;
        flashlight.SetActive(flashlightState);
        clicksToFix = flashlightState ? 1 : Random.Range(1, 15);
        
        Debug.Log($"Set amount of clicks to {clicksToFix}");
    }
}
