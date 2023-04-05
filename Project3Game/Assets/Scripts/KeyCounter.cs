using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class KeyCounter : MonoBehaviour
{
    public int countCollisions = 3;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject textbox;
    public GameObject textbox1;
    public GameObject textbox2;
    public GameObject textbox3;

    public void Start()
    {
        door1 = GameObject.Find("Door1");
        textbox= GameObject.Find("Text1");
        textbox.gameObject.SetActive(false);
    }
    public void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            textbox.gameObject.SetActive(true);
            countCollisions--;

        }

        if (countCollisions <= 0)
        {
            UnlockDoor();
        }


    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            textbox.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
    private void UnlockDoor()
    {
        Destroy(door1);
    }
    
}
