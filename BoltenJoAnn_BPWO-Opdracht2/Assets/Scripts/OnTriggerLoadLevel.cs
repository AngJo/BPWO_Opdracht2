using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerLoadLevel : MonoBehaviour {

    public string levelToLoad;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(levelToLoad);
    }
}
