using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cam_Locker : MonoBehaviour {
    public Right_Door Right;
    public int WhatIsCam;
    public int C_Lock;
    public MeshRenderer Static;
    public CanvasRenderer CR;

    // Use this for initialization
    void Start () {
        CR.SetAlpha(0);

    }
	
	// Update is called once per frame
	void Update () {
        Static = GetComponent<MeshRenderer>();
        WhatIsCam = Right.CamMov;
        if (WhatIsCam == 0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                C_Lock++;
            }
            if (C_Lock == 2)
            {
                C_Lock = 0;
            }
            if (C_Lock == 1)
            {
                Static.enabled = true;
                CR.SetAlpha(1);
            }
            if (C_Lock == 0)
            {
                Static.enabled = false;
                CR.SetAlpha(0);
            }
        }	
	}
}
