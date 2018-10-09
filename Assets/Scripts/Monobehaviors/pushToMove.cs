using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushToMove : MonoBehaviour {

    public GameObject gameobject;
    Rigidbody rb;
    public int force;
    Vector3 jump;
    Vector3 moveForward;
    Vector3 moveBackward;
    public StatContainer_SO stat;
	// Use this for initialization
	void Start () {
        gameobject = gameObject;
        rb = gameObject.GetComponent<Rigidbody>();
        jump = new Vector3(0, force, 0);
        moveForward = new Vector3(-force, 0, -force);
	}
	
	// Update is called once per frame
	void Update () {

        stat.updateCharHealth(-.01f);

        if(Input.GetKeyDown("space"))
        {
            rb.AddForce(jump);
            stat.jumped();
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(moveForward);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(-moveForward);
        }
        if(Input.GetKeyUp("w"))
        {
            rb.AddForce(0, 0, 0);
        }
        if (Input.GetKeyUp("s"))
        {
            rb.AddForce(0, 0, 0);
        }
        if(Input.GetKey("a"))
        {
            gameobject.transform.Rotate(Vector3.up, -50 *Time.deltaTime);
            rb.AddForce(0, 0, -force);
        }

        if(Input.GetKey("d"))
        {
            gameobject.transform.Rotate(Vector3.up, 50 * Time.deltaTime);
            rb.AddForce(0, 0, force);
        }
    }
}
