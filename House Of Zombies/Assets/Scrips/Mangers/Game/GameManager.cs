using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    [Header("Must have references")]
    [SerializeField] private GameObject playerReference;

    [Header("End of gmae menu")]
    [SerializeField] private GameObject endCanvas;
    public static Action winCondition;

    private int winCon;
    [SerializeField] private int amountOfEnemies;

    private void OnEnable()
    {
        GameManager.winCondition += IncreaseWincon;
    }

    private void Start()
    {
        endCanvas.SetActive(false);
    }
    public void IncreaseWincon()
    {
        winCon++;
        if (winCon == amountOfEnemies)
        {
            Debug.Log("win!");
            endCanvas.SetActive(true);

        }
    }
    public GameObject ReturnPlayer()
    {
        return playerReference;
    }
    public static GameObject GetNearestObejct(Transform position)
    {


        return null;
    }
}
