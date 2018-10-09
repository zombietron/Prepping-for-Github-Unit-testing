using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

    [SerializeField] int healthGain;
    [SerializeField] StatContainer_SO stat;
	// Use this for initialization
	void Start () {
        healthGain = Random.Range(0, 11);
	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && stat.getCharHealth() < 100)
        {
            stat.updateCharHealth(healthGain);
            Destroy(gameObject);        }
    }
}
