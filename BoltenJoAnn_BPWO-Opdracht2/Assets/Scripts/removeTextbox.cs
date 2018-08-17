using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeTextbox : MonoBehaviour {

    public GameObject messageBox;
    private int amountClicks = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            amountClicks += 1;

            if (amountClicks >= 2)
            {
                messageBox.SetActive(false);
            }
        }
	}
}
