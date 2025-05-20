using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Must have references")]
    [SerializeField] private GameObject playerReference;

    [Header("End of gmae menu")]
    [SerializeField] private GameObject endCanvas;
    public static Action winCondition;

    [SerializeField] private TMP_Text text;
    private int winCon;
    [SerializeField] private int amountOfEnemies;

    private void OnEnable()
    {
        GameManager.winCondition += IncreaseWincon;
    }

    private void Start()
    {
        endCanvas.SetActive(false);
        text.text = "Zombies left: " + amountOfEnemies.ToString();
    }
    public void IncreaseWincon()
    {
        winCon++;
        int temp = (amountOfEnemies - winCon);

        text.text = "Zombies left: " + temp;
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
