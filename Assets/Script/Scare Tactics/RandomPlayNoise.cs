using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlayNoise : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] List<string> audioNames = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        if(audioManager == null) audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>(); // cache audio manager
        StartCoroutine(GenerateNoise());
    }

    IEnumerator GenerateNoise(){
        while (true){
            float interval = Random.Range(15f, 20f);
            yield return new WaitForSeconds(interval);
            int choice = Random.Range(0, audioNames.Count);
            audioManager.Play(audioNames[choice]);
        }
    }
}
