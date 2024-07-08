using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTrigger : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;
    private void Start() 
    {
        dialogueTrigger.TriggerDialogue();
    }
}
