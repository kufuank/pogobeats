using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowToPlayer : MonoBehaviour
{

    [SerializeField] private GameObject po;
    [SerializeField] private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, po.transform.position, speed * Time.deltaTime);
        transform.up = po.transform.position - transform.position;
    }
}
