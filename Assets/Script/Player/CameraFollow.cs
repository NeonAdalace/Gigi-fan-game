using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] float _mouseSensitivity;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Look(Vector2 value){
        float mouseX = value.x * _mouseSensitivity * Time.deltaTime;
        float mouseY = value.y * _mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        this.transform.localRotation = Quaternion.Euler(xRotation , 0f, 0f);
        _player.Rotate(Vector3.up * mouseX);
    }
}
