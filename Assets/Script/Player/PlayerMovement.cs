using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float _speed;
    Vector3 velocity;
    float gravity = -9.81f;
    Vector2 currentDirection = Vector2.zero;

    [SerializeField] AudioManager audioManager;
    [SerializeField] string footstepAudioName;
    private void Start() {
        if(audioManager == null) audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>(); // cache audio manager
    }

    public void Move(Vector2 direction){
        currentDirection = direction;

        if(direction == Vector2.zero){ audioManager.Stop(footstepAudioName); } 
        else { audioManager.PlayLoop(footstepAudioName); }
    }
    private void Update() {
        if(currentDirection == Vector2.zero){ return; }
        Vector3 move = transform.right * currentDirection.x + transform.forward * currentDirection.y;

        controller.Move(move * _speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
