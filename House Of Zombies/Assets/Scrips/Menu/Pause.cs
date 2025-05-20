using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseUI;

    private bool pausState = false;

    private void OnEnable()
    {
        InputManager.Pause += ChangeState;
    }

    private void OnDisable()
    {
        InputManager.Pause -= ChangeState;

    }

    public void ChangeState()
    {
        Debug.Log("We are in change state");
        if(pausState == false)
        {
            pauseUI.SetActive(true);
            pausState = true;
            Time.timeScale = 0;
        }
        else
        {
            pauseUI.SetActive(false);
            pausState = false;
            Time.timeScale = 1;

        }
    }
}
