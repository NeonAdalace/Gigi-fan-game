using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    [Header("Canvas components")]
    [SerializeField] GameObject _mainCanvas;
    [SerializeField] GameObject _selectedCanvas;
    public void OnClick()
    {
        _mainCanvas.SetActive(false);
        _selectedCanvas.SetActive(true);
    }
}
