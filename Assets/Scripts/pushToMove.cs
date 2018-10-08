using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushToMove : MonoBehaviour {

    public GameObject gameobject;
    Rigidbody rb;
    public int force;
    Vector3 move;
	// Use this for initialization
	void Start () {
        gameobject = gameObject;
        rb = gameObject.GetComponent<Rigidbody>();
        move = new Vector3(0, force, 0);
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown("space"))
        {
            rb.AddForce(move);
        }
		
	}
}
