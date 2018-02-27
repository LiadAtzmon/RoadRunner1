using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidingMessanging : MonoBehaviour {
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            
            Debug.Log("Ur Dead mun");
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
