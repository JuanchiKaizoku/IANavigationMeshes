using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject target;
    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
        if (agent.remainingDistance < 2){
            anim.SetBool("isMoving", false);
        }
        else{
            anim.SetBool("isMoving", true);
        }
    }
}
