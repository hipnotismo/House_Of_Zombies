using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [SerializeField] TrailRenderer bulletTrail;
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

        if (Physics.Raycast(spawnPosition, spawnDirection, out hit, float.MaxValue))
        {
            TrailRenderer trail = Instantiate(bulletTrail, spawnPosition, Quaternion.identity);

            StartCoroutine(SpawnTrail(trail, hit.point, hit.normal, true));

        }
        else
        {
            TrailRenderer trail = Instantiate(bulletTrail, spawnPosition, Quaternion.identity);

            StartCoroutine(SpawnTrail(trail, spawnPosition + spawnDirection * 100, Vector3.zero, false));

        }

        Physics.Raycast(spawnPosition, spawnDirection, out hit, 100f);

        ITakeDamage isHit = hit.collider.GetComponent<ITakeDamage>();

        if (isHit != null)
        {
            isHit.TakeDamage();
        }

    }

    private IEnumerator SpawnTrail(TrailRenderer Trail, Vector3 HitPoint, Vector3 HitNormal, bool MadeImpact)
    {
        
        Vector3 startPosition = Trail.transform.position;
        float distance = Vector3.Distance(Trail.transform.position, HitPoint);
        float remainingDistance = distance;

        while (remainingDistance > 0)
        {
            Trail.transform.position = Vector3.Lerp(startPosition, HitPoint, 1 - (remainingDistance / distance));

            remainingDistance -= 100f * Time.deltaTime;

            yield return null;
        }
        Trail.transform.position = HitPoint;
        

        Destroy(Trail.gameObject, Trail.time);
    }
}
