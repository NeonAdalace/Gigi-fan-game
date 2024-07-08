using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScreenSizes : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;
        dropdown.ClearOptions();
        List<string> options = new();
        int currentIndex = 0;
        for(int i = 0; i<resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
        
            if(resolutions[i].width == Screen.currentResolution.width 
            && resolutions[i].height == Screen.currentResolution.height)
            {
                currentIndex = i;
            }
        }
        dropdown.AddOptions(options);
        dropdown.value = currentIndex;
        dropdown.RefreshShownValue();
    }

    public void SetResolution(int index)
    {
        Resolution resolution = resolutions[index];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
