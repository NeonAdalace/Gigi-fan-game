using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextChoice : MonoBehaviour
{
    [SerializeField] DialogueTrigger _dialogueTrigger;
    [SerializeField] DialogueScript[] _dialogueScript;
    private Queue<DialogueScript> _nextChoice = new();

    private void Start() 
    {
        foreach(DialogueScript script in _dialogueScript)
        {
            _nextChoice.Enqueue(script);
        }
        if(_nextChoice.Count == 0){return;}
        _dialogueTrigger.dialogue = _nextChoice.Dequeue();
    }
    public void OnClickQueue()
    {
        if(_nextChoice.Count == 0){return;}
        _dialogueTrigger.dialogue = _nextChoice.Dequeue();
    }
    // NOTE: Always Dequeue after every choice
    public void OnClickDequeue()
    {
        if(_nextChoice.Count == 0){ return; }
        _nextChoice.Dequeue();
    }
}
