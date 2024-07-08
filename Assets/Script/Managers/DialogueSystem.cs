using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour 
{
    [Header("UI Components")]
    public GameObject DialogueCanvas;
    [SerializeField] TextMeshProUGUI _dialogueText;
    [SerializeField] TextMeshProUGUI _characterName;
    private Queue<Dialogue> _dialogue = new();

    Dialogue _script;
    string _sentence;
    string _name;

    public int getCount { get{ return _dialogue.Count; } }
    public bool isSceneEnding { get{ return _dialogue.Count == 0 ? true : false; } }
    public bool isComplete;
    public void DisplayDialogue(DialogueScript dialogueScript)
    {        
        _dialogue.Clear();
        foreach(Dialogue script in dialogueScript.dialogue)
        {
            _dialogue.Enqueue(script);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(_dialogue.Count == 0){ return; }
        if(!isComplete){ return; }
        
        isComplete = false;
        
        _script = _dialogue.Dequeue();
        
        _sentence = _script.sentences;
        
        _name = _script.name;
        _characterName.text = _name;
        
        // default text animation
        StartCoroutine(TypeWriter(_sentence));
    }
    
    // animation styles
    IEnumerator TypeWriter(string sentence)
    {
        for(int i = 0; i < sentence.Length + 1; i++)
        {
            _dialogueText.text = sentence.Substring(0, i);
            yield return null;
        }
        isComplete = true;
    }
    // TODO: create a fade in 
}
