using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    [Header("Must have references")]
    [SerializeField] private GameObject playerReference;

    [Header("Maybe have references")]
    [SerializeField] private List<GameObject> barricadeReference;
    public static Action winCondition;

    private int winCon;
    [SerializeField] private int amountOfEnemies;

    private void OnEnable()
    {
        GameManager.winCondition += IncreaseWincon;
    }

    public void IncreaseWincon()
    {
        winCon++;
        if (winCon == amountOfEnemies)
        {

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
