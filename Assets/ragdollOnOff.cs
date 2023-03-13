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

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if ((collision.gameObject.tag == "Right_Ctrl") || collision.gameObject.tag == "Left_Ctrl")
    //    {
    //        RagdollModeOn();
    //        Debug.Log(collision.transform.name);

    //    }

    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    RagdollModeOn();
    //    Debug.Log("Name"+ other.gameObject.transform.name);
    //}

    Collider[] ragDollColliders;
    Rigidbody[] limbsRigidbodies;
    void GetRagdollBits()
    {
        ragDollColliders = ThisGuyRig.GetComponentsInChildren<Collider>();
        limbsRigidbodies = ThisGuyRig.GetComponentsInChildren<Rigidbody>();
    }
    public void RagdollModeOn()
    {
        Debug.Log("RAGDOL");
        ThisGuyAnimator.enabled = false;
        foreach (Collider col in ragDollColliders)
        {
            col.enabled = true;
        }

        foreach (Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = false;
            rigid.useGravity = false;

        }

        
        mainCollider.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true ;
        GetComponent<Rigidbody>().useGravity = true;


        Destroy(gameObject, 2f);


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
            rigid.useGravity = false;

        }

        ThisGuyAnimator.enabled = true;
        mainCollider.enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().useGravity = false;

    }

}
