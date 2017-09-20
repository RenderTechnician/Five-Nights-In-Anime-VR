using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Freddy : MonoBehaviour {

    public int timer;
    public int whoisit;
    public GameObject freddy;
    // Use this for initialization
    void Start()
    {
        Freddy();
    }

    // Update is called once per frame
    void Update()
    {

        timer++;
        if (timer > 1000)
        {
            Freddy_Off();
        }
        
    }
    void Freddy()
    {
        transform.position = new Vector3(0.0f, 0f, -3.8f);

    }
    void Freddy_Off()
    {
        transform.position = new Vector3(0.0f, -5f, 0.0f);
    }
}
