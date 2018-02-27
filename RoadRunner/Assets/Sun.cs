using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {
    Vector3 ssPosition = new Vector3(-179, 0, 569);
    Vector3 Sunriser = new Vector3(0, 2, -1);
    Vector3 Sunsetter = new Vector3(0, 1, 0);
	// Use this for initialization
	void Start () {
        transform.position = ssPosition;
        

	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= 437)
        {
         //transform.position.y = transform.position.y + 0.002f; 
         //transform.position.z = transform.position.z - 0.001f;
        }
        
        //transform.position = transform.position - Sunsetter;
		
	}
}
