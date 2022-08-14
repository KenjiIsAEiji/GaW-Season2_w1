using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerInput playerInput;
    CubeController cubeController;
    private void Awake()
    {
        TryGetComponent(out playerInput);
        TryGetComponent(out cubeController);
    }

    private void OnEnable()
    {
        playerInput.actions["Fire"].started += OnFire;
        playerInput.actions["LeftMove"].started += OnLeftMove;
        playerInput.actions["RightMove"].started += OnRightMove;
    }

    private void OnDisable()
    {
        playerInput.actions["Fire"].started -= OnFire;
        playerInput.actions["LeftMove"].started -= OnLeftMove;
        playerInput.actions["RightMove"].started -= OnRightMove;
    }

    private void OnFire(InputAction.CallbackContext obj)
    {
        Debug.Log("OnFire!!");
    }

    private void OnLeftMove(InputAction.CallbackContext obj)
    {
        cubeController.MoveToLeft();
        Debug.Log("OnLeftMove");
    }

    private void OnRightMove(InputAction.CallbackContext obj)
    {
        cubeController.MoveToRight();
        Debug.Log("OnRightMove");
    }
}
