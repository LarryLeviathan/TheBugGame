using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControl : MonoBehaviour {
    public int Health;
    public Renderer rend;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.lives < Health)
        {
            rend = GetComponent<Renderer>();
            rend.enabled = false;
        }
        else
        {
            rend = GetComponent<Renderer>();
            rend.enabled = true;
        }
    }
}
