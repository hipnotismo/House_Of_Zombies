using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Must have references")]
    [SerializeField] private GameObject playerReference;

    [Header("Maybe have references")]
    [SerializeField] private List<GameObject> barricadeReference;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
