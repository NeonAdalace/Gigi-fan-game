using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerBehavior : MonoBehaviour
{
    PlayerControls controls;
    [SerializeField] PlayerMovement _movement;
    [SerializeField] CameraFollow _look;
    [SerializeField] ReturnToMenu returnToMenu;
    [SerializeField] FlashlightBehavior flashlightBehavior;

    void Awake()
    {
        controls = new PlayerControls();
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        OnEnable();
        controls.Player.Move.performed += _ => _movement.Move(_.ReadValue<Vector2>());
        controls.Player.Move.canceled += _ => _movement.Move(Vector2.zero);

        controls.Player.Look.performed += _ => _look.Look(_.ReadValue<Vector2>());

        controls.Player.Pause.performed += _ => returnToMenu.OnClick();
        controls.Player.Interact.performed += _ => flashlightBehavior.OnClick(); 
        // character = (CharacterSO)gameObject.GetComponent<SetEntitySO>().GetEntity;
    }
}
