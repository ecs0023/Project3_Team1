using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    public Text dialogue;
    void Start()
    {
        dialogue.gameObject.SetActive(false);
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) 
        {
            dialogue.gameObject.SetActive(true);        
        }
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            dialogue.gameObject.SetActive(false);
        }
    }
}
