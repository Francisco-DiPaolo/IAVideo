using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class Ortis : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animator;
    public Transform target;
    private void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("SetDestination", 0f, 1f);
    }
    private void Update()
    {
        if (agent.velocity.magnitude <= 0.1f)
        {
            animator.SetBool("IsWalking", false);
        }
        else
        {
            animator.SetBool("IsWalking", true);
        }
    }
    void SetDestination()
    {
        agent.destination = target.position;
    }
}
