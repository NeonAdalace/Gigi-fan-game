using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipTrigger : MonoBehaviour
{
    [SerializeField] private DialogueSystem _dialogueManager;
    [SerializeField] private DialogueQueue _dialogueQueue; 
    [SerializeField] private bool isSkipping;
    [SerializeField] private float delaySeconds;
    [SerializeField] private float counter;
    [SerializeField] private GameObject notice; 
    public void OnClick()
    {
        isSkipping = isSkipping ? false : true;
        notice.SetActive(isSkipping);
        counter = 0;
    }
    private void Update() 
    {
        if(!isSkipping){ return; }
        if(counter < delaySeconds)
        {
            counter += Time.deltaTime;
            return;
        }
        counter = 0f;
        if(_dialogueQueue != null)
        {
            _dialogueQueue.OnClick();
            _dialogueManager.isComplete = true;
            // if(_dialogueQueue.isSceneEnding){ isSkipping = false; }
            return;
        }
        if(_dialogueManager != null)
        {
            _dialogueManager.DisplayNextSentence();
            _dialogueManager.isComplete = true;
            // if(_dialogueManager.isSceneEnding){ isSkipping = false; }
            return;
        }
    }
}
