using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour

{
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent nMesh = GetComponent<NavMeshAgent>();

        nMesh.destination = player.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
