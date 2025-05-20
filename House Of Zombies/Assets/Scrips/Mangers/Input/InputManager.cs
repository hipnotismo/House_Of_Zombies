using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputManager : MonoBehaviour
{
    public delegate void PlayerMoveAction(Vector2 dir);
    public static event PlayerMoveAction MovePlayer;

    public static Action<Vector2> MoveCamera;
    public static Action Fire;
    public static Action Pause;

    public void OnMove(InputValue inputValue)
    {
        var movementInput = inputValue.Get<Vector2>();
        MovePlayer(movementInput);
    }

    public void OnLook(InputValue inputValue)
    {

        var cameraInput = inputValue.Get<Vector2>();
        MoveCamera(cameraInput);
    }

    public void OnFire()
    {
        Fire();
    }

    public void OnPause()
    {
        Pause();
        Debug.Log("Pause");

    }
}
