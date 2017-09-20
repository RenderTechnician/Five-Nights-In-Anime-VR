using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Raycast : MonoBehaviour {
    public float rayDistance = 3;
    public Vector3 Offset;

    void FixedUpdate()
    {
        Ray ray = new Ray(transform.position + Offset, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red);
            if (hit.transform.tag.Equals("Right_Door_Button"))
            {

            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
