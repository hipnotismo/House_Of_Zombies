using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour, ITakeDamage
{
    [SerializeField] private int initialHealth;
    private int currentHealth;
    private bool immune;

    void Start()
    {
        currentHealth=initialHealth;
        immune  =   false;
    }

    public void TakeDamage()
    {
        if (immune  ==  false)
        {
            currentHealth--;
            StartCoroutine(immunity());
        }    
        
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator immunity()
    {
        immune = true;
        yield return new WaitForSeconds(2);
        immune = false;
    }
}
