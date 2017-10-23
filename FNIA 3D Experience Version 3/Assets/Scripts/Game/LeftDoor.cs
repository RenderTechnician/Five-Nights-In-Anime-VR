using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoor : MonoBehaviour {
    public Right_Door RD_passthrough;
    public int DoorCodePass;
    public Animator anim2;
    // Use this for initialization
    void Start () {
        anim2 = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        DoorCodePass = RD_passthrough.DoorCode2;
        if (DoorCodePass == 0)
        {
            anim2.Play("Left_Door_Up");
        }
        if (DoorCodePass == 1)
        {
            anim2.Play("Left_Door_Down");
        }
    }
}
