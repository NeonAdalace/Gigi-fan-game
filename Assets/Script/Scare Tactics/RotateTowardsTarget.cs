using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsTarget : MonoBehaviour
{
    [SerializeField] Transform target;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FindTargetLocation());
    }

    IEnumerator FindTargetLocation(){
        while(true){
            yield return new WaitForSeconds(5f);
            transform.position = Vector3.MoveTowards(transform.position, target.position, Random.Range(5f, 10f));
            transform.LookAt(target, Vector3.up);
        }
    }
}
