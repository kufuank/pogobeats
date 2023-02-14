using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handbomb : MonoBehaviour
{
    public float force;
    public float radius;



    private void OnCollisionEnter(Collision collision)
    {
        Vector3 exPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(exPos, radius);
        foreach(Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if(rb != null)
            {

               
                rb.AddExplosionForce(force, exPos, radius, 0.05f, ForceMode.Impulse);
            }
        }
    }
}



