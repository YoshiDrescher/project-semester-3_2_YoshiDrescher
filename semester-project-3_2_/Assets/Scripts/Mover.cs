using System;
using System.Collections;
using System.Collections.Generic;
using NavMeshPlus.Editors.Extensions;
using NavMeshPlus.Extensions;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(AgentOverride2d))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Mover : MoverBase
{
    [SerializeField] private float radius = .5f;
    [SerializeField] private Transform body;
    
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }
    
    

    public void SetMovementTarget(Vector2 position)
    {
        agent.isStopped = false;
        agent.SetDestination(position);
    }

    

    public void CancelMovement()
    {
        agent.isStopped = true;
    }

    public Vector2 GetPosition()
    {
        return transform.position;
        
    }

    public float GetRadius()
    {
        return radius;
    }

    private void OnValidate()
    {
        GetComponent<CircleCollider2D>().radius = radius;
        GetComponent<NavMeshAgent>().radius = radius;
        GetComponent<NavMeshAgent>().height = 0;
        if (body != null)
            body.localScale = new Vector3(radius * 2, radius * 2, radius * 2);
    }
    
    
}
