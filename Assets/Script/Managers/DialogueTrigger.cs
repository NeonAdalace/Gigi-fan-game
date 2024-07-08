using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// fix to acomodate for new Dialogue system
public class DialogueTrigger : MonoBehaviour 
{
    public DialogueSystem _dialogueSystem;   
    public DialogueScript dialogue;
    public void TriggerDialogue() => _dialogueSystem.DisplayDialogue(dialogue);
}
