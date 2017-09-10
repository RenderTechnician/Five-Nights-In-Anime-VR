using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour {
    public LayerMask Right;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(transform.position, transform.forward, 100, Right.value))
            Debug.Log("Hit something");
    }
}
