using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMainTheme : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string _audioName;
    void Start()
    {
        GameObject.FindWithTag("AudioManager").GetComponent<AudioManager>().PlayLoop(_audioName);
    }
}
