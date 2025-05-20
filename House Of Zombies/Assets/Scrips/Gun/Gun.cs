using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private void OnEnable()
    {
        InputManager.Fire += Shoot;
    }
    private void OnDisable()
    {
        InputManager.Fire -= Shoot;
    }

  
    public void Shoot()
    {
        RaycastHit hit;

        Vector3 spawnPosition = transform.position;
        Vector3 spawnDirection = transform.forward;

        Physics.Raycast(spawnPosition, spawnDirection, out hit, 100f);
        Debug.Log(hit.collider.name);

        ITakeDamage isHit = hit.collider.GetComponent<ITakeDamage>();

        if (isHit != null)
        {
            isHit.TakeDamage();
        }

    }
}
