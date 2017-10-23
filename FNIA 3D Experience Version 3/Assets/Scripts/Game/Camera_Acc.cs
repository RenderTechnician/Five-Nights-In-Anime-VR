using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Acc : MonoBehaviour {
    public Right_Door RightBridge;
    public int Zoomer;
    public Animator Zooms;

	// Use this for initialization
	void Start () {
        Zooms = GetComponent<Animator>();
        
    }
	
	// Update is called once per frame
	void Update () {
        Zoomer = RightBridge.CamMov;
        if (Zoomer == 0)
        {
            Zooms.Play("To_Monitor");
        }
        if (Zoomer == 1)
        {
            Zooms.Play("Away_From_Monitor");
        }
    }
}
