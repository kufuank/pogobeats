using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ragdollOnOff : MonoBehaviour
{
    public BoxCollider mainCollider;
    public GameObject ThisGuyRig;
    public Animator ThisGuyAnimator;
    void Start()
    {
        GetRagdollBits();
        RagdollModeOff();
    }

 
    void Update()
    {
        
  
    }

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "MyNewCollisionTag") 
        {
            RagdollModeOn();
        } 
    }

    Collider[] ragDollColliders;
    Rigidbody[] limbsRigidbodies;
    void GetRagdollBits()
    {
        ragDollColliders = ThisGuyRig.GetComponentsInChildren<Collider>();
        limbsRigidbodies = ThisGuyRig.GetComponentsInChildren<Rigidbody>();
    }
    void RagdollModeOn()
    {
        ThisGuyAnimator.enabled = false;
        foreach (Collider col in ragDollColliders)
        {
            col.enabled = true;
        }

        foreach (Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = false;

        }

        
        mainCollider.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true ;


    }

    void RagdollModeOff ()
    {
        foreach(Collider col in ragDollColliders)
        {
            col.enabled = false;
        }

        foreach(Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = true;

        }

        ThisGuyAnimator.enabled = true;
        mainCollider.enabled = true;
        GetComponent<Rigidbody>().isKinematic = false; 

    }

}
