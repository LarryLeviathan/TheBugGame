using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public int limit = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        {
            if (limit >= -5 && Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down);
                limit--;
            }
            if (limit <= 1 && Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up);
                limit++;
            }
        }
		
    }
}
