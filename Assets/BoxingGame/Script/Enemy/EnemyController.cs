using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    RandomBoxingAnimations animations;

    private void Start()
    {
        animations = GetComponent<RandomBoxingAnimations>();
        //animator = GetComponent<Animator>();
        target = PlayerManager.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            //animator.SetBool("isWalk", true);
            animations.Iswalking(true);


            if (distance <= agent.stoppingDistance)
            {
                //Attack the target
                //animator.SetBool("Walk", false);
                

                FaceTarget();
            }
        }
        animations.Iswalking(false);
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x,0,direction.z));

        transform.rotation = Quaternion.Slerp(transform.rotation , lookRotation, Time.deltaTime*5f);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
