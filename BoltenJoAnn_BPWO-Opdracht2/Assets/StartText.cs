using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour {

    public GameObject messageBox;
    public Text text;
    public string textToDisplay1;
    public string textToDisplay2;
    private int textRead = 0;

    // Use this for initialization
    void Start () {
        messageBox.SetActive(true);
        text.text = textToDisplay1;
        Debug.Log("Text Displaying 1");
        textRead = 1;
        Debug.Log("TextRead = 1");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Down");
            if (textRead == 1)
            {
                Debug.Log("TextRead == 1");
                text.text = textToDisplay2;
                Debug.Log("Text Displaying 2");
                textRead = 2;
                return;
            }
            else if (textRead == 2)
            {
                messageBox.SetActive(false);
                return;
            }
        }
        
    }
}
