using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] int _scene;
    public void OnClick()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(_scene);
    }
}
