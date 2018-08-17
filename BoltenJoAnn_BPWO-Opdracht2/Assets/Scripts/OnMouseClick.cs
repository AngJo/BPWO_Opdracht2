using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMouseClick : MonoBehaviour {

    public Image img;
    public GameObject messageBox;
    public Text text;
    public string textToDisplay;
    private int textRead = 0;
    // Use this for initialization
    void Start () {
        messageBox.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (textRead == 0)
            {
                messageBox.SetActive(true);
                text.text = textToDisplay;
                textRead = 1;
                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    if (hit.transform)
                    {
                        Destroy(gameObject);
                    }

                    
                }
                
            }
            


            
        }

        if (Input.GetMouseButtonDown(1))
        {
            messageBox.SetActive(false);
        }
    }

    
}
