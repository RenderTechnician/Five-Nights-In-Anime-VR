using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hour : MonoBehaviour {
    public int Timer;
    public int time_display;
    public Text text;
	// Use this for initialization
	void Start () {
        time_display = 12;	
	}
	
	// Update is called once per frame
	void Update () {
        Timer++;
        text.text = time_display + " AM";
        if(Timer > 7649)
        {
            time_display++;
            Timer = 0;
        }
        if (time_display == 13)
        {
            time_display = 1;
        }
        if (time_display == 6)
        {
            Application.LoadLevel("6AM");
        }
	}
}
