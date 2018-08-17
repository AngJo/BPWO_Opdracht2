using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningFlash : MonoBehaviour {

    public Light myLight;
	// Use this for initialization
	void Start () {
        myLight.enabled = false;
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        myLight.enabled = true;
        new WaitForSeconds(3f);
        myLight.enabled = false;
    }
}
