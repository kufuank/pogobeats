using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnHuman : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private Vector3 screenBounds;




    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < screenBounds.z )
        {
            Destroy(this.gameObject);
        }
    }
}
