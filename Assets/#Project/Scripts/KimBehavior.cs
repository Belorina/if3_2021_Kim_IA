using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class KimBehavior : MonoBehaviour
{

    public Vector3 destination;
    
    private Pool pool;

    void Start()
    {
        pool = FindObjectOfType<Pool>();
    }

    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
    
    void OnMouseUp()
    {
        //pool.Kill(this);
        GetComponent<Renderer>().material.color = Color.black;
    }

    void Restore()
    {
        GetComponent<Renderer>().material.color = Color.red;

    }

  
}
