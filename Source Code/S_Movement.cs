using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Movement : MonoBehaviour {

    Rigidbody rb;

    public float speed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.AddForce(transform.right * speed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "End")
        {
            Destroy(gameObject);
        }
    }
}
