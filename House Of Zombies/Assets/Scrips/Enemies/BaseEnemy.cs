using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.HID;
using static UnityEngine.GraphicsBuffer;

public class BaseEnemy : MonoBehaviour, ITakeDamage
{
    [SerializeField]private GameObject barricadeTarget;
    [SerializeField] private GameObject playerTarget;

    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    void Update()
    {
        if(barricadeTarget != null)
        {
            navMeshAgent.destination = barricadeTarget.transform.position;

        }
        else
        {
            navMeshAgent.destination = playerTarget.transform.position;

        }
        
    }

    public void SetTarget(GameObject target,GameObject playerTar)
    {
        barricadeTarget = target;
        playerTarget=playerTar;
    }

    public void TakeDamage()
    {
        GameManager.winCondition();
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Enemy")
        {
            Debug.Log("Colliswon");

            ITakeDamage isHit = other.GetComponent<ITakeDamage>();

            if (isHit != null)
            {
                Debug.Log(isHit);

                isHit.TakeDamage();
            }

        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag != "Enemy")
        {
            Debug.Log("Colliswon");

            ITakeDamage isHit = collision.collider.GetComponent<ITakeDamage>();

            if (isHit != null)
            {
                Debug.Log(isHit);

                isHit.TakeDamage();
            }

        }
    }
}
