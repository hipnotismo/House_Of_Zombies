using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public delegate void PlayerMoveAction(Vector2 dir);
    public static event PlayerMoveAction MovePlayer;

    public void OnMove(InputValue inputValue)
    {
        Debug.Log("HERE!");
        var movementInput = inputValue.Get<Vector2>();
        MovePlayer(movementInput);
    }

}
