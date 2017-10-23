using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Transist : MonoBehaviour {
    public int time;
    
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        time++;
        if (time >= 600)
        {
            Transfer();
        }
      
        
	}
    void Transfer()
    {
        Application.LoadLevel("Main Menu");
    }
}
