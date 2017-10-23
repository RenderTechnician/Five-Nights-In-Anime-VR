using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDoor : MonoBehaviour {
    public Right_Door RD_passthrough;
    public int DoorCodePass;
    public Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();   
        
	}
	
	// Update is called once per frame
	void Update () {
        DoorCodePass = RD_passthrough.DoorCode;  

        if (DoorCodePass == 0)
        {
            anim.Play("Right_Door_Up");
        }
        if (DoorCodePass == 1)
        {
            anim.Play("Door_Right_Down");
        }
       
    }
    
   
}
