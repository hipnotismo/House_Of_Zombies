using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private void OnEnable()
    {
        anim = GetComponent<Animator>();
        InputManager.MovePlayer += Movement;
    }


    private void OnDisable()
    {
        InputManager.MovePlayer -= Movement;
    }

    public void Movement(Vector2 direction)
    {
        var movementInput = direction;
        Debug.Log(movementInput.x + " : " + movementInput.y);
        if (movementInput.x != 0 || (movementInput.y != 0))
        {
            anim.SetBool("Run",true);
        }
        else
        {
            anim.SetBool("Run", false);

        }

    }
}
