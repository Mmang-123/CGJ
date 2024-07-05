using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    private NavMeshAgent _agent;

    public Transform player;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;

        _agent.SetDestination(player.position);
    }

    private void Update()
    {
        if (_agent.remainingDistance > 0.5f)
        {
            _agent.SetDestination(player.position);
        }
    }
}
