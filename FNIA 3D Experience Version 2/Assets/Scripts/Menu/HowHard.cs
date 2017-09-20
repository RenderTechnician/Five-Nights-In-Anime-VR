using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowHard : MonoBehaviour {

    public AudioSource Setter;
    public int Diffset;
    public TextMesh text;

    // Use this for initialization
    void Start() {
        Diffset = 1;
    }
    
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Diffset++;
            Setter.Play();
        }
        if (Diffset == 1)
            {
                GetComponent<TextMesh>().text = "Easy";
            }
            if (Diffset == 2)
            {
                GetComponent<TextMesh>().text = "Medium";
            }
            if (Diffset == 3)
            {
                GetComponent<TextMesh>().text = "Hard";
            }
            if (Diffset == 4)
            {
                GetComponent<TextMesh>().text = "Very Hard";
            }
            if (Diffset == 5)
            {
                GetComponent<TextMesh>().text = "Impossible";
            }
            if (Diffset == 6)
            {
                Diffset = 1;
                GetComponent<TextMesh>().text = "Easy";
            }
        }
    

}
