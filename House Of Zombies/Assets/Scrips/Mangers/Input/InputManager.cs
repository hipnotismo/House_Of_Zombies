using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputManager : MonoBehaviour
{
    public delegate void PlayerMoveAction(Vector2 dir);
    public static event PlayerMoveAction MovePlayer;

    //public delegate void CameraMoveAction(Vector2 dir);
    //public static event CameraMoveAction MoveCamera;

    public static Action<Vector2> MoveCamera;
    public void OnMove(InputValue inputValue)
    {
        Debug.Log("HERE!");
        var movementInput = inputValue.Get<Vector2>();
        MovePlayer(movementInput);
    }

    public void OnLook(InputValue inputValue)
    {

        var cameraInput = inputValue.Get<Vector2>();
        MoveCamera(cameraInput);
    }
}
