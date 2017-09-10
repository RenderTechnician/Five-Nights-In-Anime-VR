using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Navigation : MonoBehaviour {
    public int whichone;
    public TextMesh StartGame;
    public TextMesh Diff;
    public TextMesh Extras;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            whichone--;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            whichone++;
        }
        if (whichone == -1)
        {
            StartGame.color = Color.white;
            Diff.color = Color.white;
            Extras.color = Color.yellow;
            whichone = 2;
                }
            if (whichone == 0)
        {
            StartGame.color = Color.yellow;
            Diff.color = Color.white;
            Extras.color = Color.white;

        }
        if (whichone == 1)
        {
            StartGame.color = Color.white;
            Diff.color = Color.yellow;
            Extras.color = Color.white;

        }
        if (whichone == 2)
        {
            StartGame.color = Color.white;
            Diff.color = Color.white;
            Extras.color = Color.yellow;

        }
        if (whichone == 3)
        {
            StartGame.color = Color.yellow;
            Diff.color = Color.white;
            Extras.color = Color.white;
            whichone = 0;
        }
    }
    public void LoadLevel()
    {
        Debug.Log("123456");
        Application.LoadLevel("Game");
        
    }
  
}
