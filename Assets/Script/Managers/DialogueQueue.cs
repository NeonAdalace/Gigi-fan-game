using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DialogueQueue : MonoBehaviour
{
    [SerializeField] DialogueSystem _dialogueSystem;
    
    private AudioManager audioManager;
    [SerializeField] string nowPlaying;
    [SerializeField] GameObject display;
    private void Awake()
    {
        audioManager = GameObject.FindWithTag("AudioManager").GetComponent<AudioManager>();
    }
    public void OnClick() {
        // if(isTransitioning){ return; }
        if(_dialogueSystem.getCount <= 0)
        {
            Time.timeScale = 1f;
            if(display != null){
                display.SetActive(true);
            }
            return;
        }
        if(_dialogueSystem.getCount > 0)
        {
            _dialogueSystem.DisplayNextSentence();
            return;
        }

        // if(sceneData.location != null) { StartCoroutine(Transition(sceneData)); }

        // if(sceneData.audioName != nowPlaying && sceneData.audioName != ""){
        //     Debug.Log($"now playing: {sceneData.audioName}");
        //     audioManager.Stop(nowPlaying);
        //     audioManager.PlayLoop(sceneData.audioName);
        // }

        // _dialogueSystem.DisplayDialogue(sceneData.script); 
    }

}