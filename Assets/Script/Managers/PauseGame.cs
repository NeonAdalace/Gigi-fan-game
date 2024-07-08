using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour{
    [Header("References")]
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public void Pause()
    {
        if(PauseMenuUI != null){ PauseMenuUI.SetActive(true); }
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
