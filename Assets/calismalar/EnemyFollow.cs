using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour

{
    public Transform player;
    NavMeshAgent nMesh;

    // Start is called before the first frame update
    void Start()
    {
   nMesh = GetComponent<NavMeshAgent>();

        
    }

    // Update is called once per frame
    void Update()
    {
        nMesh.destination = player.position;
    }
}
