using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour {
    public int power;
    public int PowerLevel;
    public Text text;
    public Sprite[] Spriter;
    public SpriteRenderer Powering;
    public Right_Door RD_REF;
    public int RDC;
    public int LLC;
    public int LLB;
    public int LDB;
    public int count;
    public int drop;
	// Use this for initialization
	void Start () {
        power = 99;   
	}
	
	// Update is called once per frame
	void Update () {
        text.text = ("Power: " + power + "%");
        int SpriteIndex = PowerLevel;
        this.Powering.sprite = Spriter[SpriteIndex];
        RDC = RD_REF.DoorCode;
        LLC = RD_REF.IsLightR;
        LLB = RD_REF.IsLightL;
        LDB = RD_REF.DoorCode2;
        PowerLevel = RDC + LLC + LLB + LDB;
        
        count++;
        if (RDC == 1)
        {
            count++;
        }
        if (LLC == 1)
        {
            count++;
        }
        if (count > 600)
        {
            power--;
            count = 0;
        }
        
    }
}
