using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    [SerializeField]GameObject camera;
    [SerializeField] GameObject followObject;
    [SerializeField] Transform cameraTransform;
    Vector3 followTransform;

    // Use this for initialization
    void Start()
    {
        camera = gameObject;
    }
	// Update is called once per frame
	void Update () {

        camera.transform.position = new Vector3(followObject.transform.position.x + 3f, followObject.transform.position.y + 4, followObject.transform.position.z + 3f);
		
	}
}
