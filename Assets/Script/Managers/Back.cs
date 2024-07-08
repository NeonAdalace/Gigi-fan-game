using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour 
{
    [Header("Canvas components")]
    [SerializeField] GameObject _mainCanvas;
    [SerializeField] GameObject _currentCanvas;
    public void OnClick()
    {
        _mainCanvas.SetActive(true);
        _currentCanvas.SetActive(false);
    }
}
