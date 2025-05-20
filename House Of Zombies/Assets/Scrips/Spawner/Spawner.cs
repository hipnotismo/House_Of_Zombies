using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.GraphicsBuffer;

public class Spawner : MonoBehaviour
{
    [Header("Barricade")]
    [SerializeField] private GameObject barricadeReference;

    [Header("Enemy")]
    [SerializeField] private GameObject enemyPrefab;

    [Header("Player")]
    [SerializeField] private GameObject playerPrefab;

    public static Action returnReference;

    void Start()
    {
        GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        BaseEnemy enemyScript = newEnemy.GetComponent<BaseEnemy>();
        if (enemyScript != null)
        {
            enemyScript.SetTarget(barricadeReference, playerPrefab);
        }

    }

   

    
}
