using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    public GameObject dotMove;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = dotMove.transform.position;
    }
}

