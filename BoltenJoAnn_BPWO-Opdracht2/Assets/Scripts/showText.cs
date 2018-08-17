using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class showText : MonoBehaviour {

    public GameObject messageBox;
    public Text text;
    public string textToDisplay;
    private int textRead = 0;

    private void OnMouseDown()
    {
        if (textRead == 0)
        {
            messageBox.SetActive(true);
            text.text = textToDisplay;
            textRead = 1;
            return;
        }
        else if (textRead == 1)
        {
            messageBox.SetActive(false);
            textRead = 0;
            return;
        }
        
        //show text
        
    }
    // Use this for initialization
    void Start () {
        messageBox.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
