using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour

    
{

    public GameObject exp;
    public float expForce, radius;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject _exp = Instantiate(exp, transform.position, transform.rotation);
        Destroy(_exp, 3); 
    }

   
}
