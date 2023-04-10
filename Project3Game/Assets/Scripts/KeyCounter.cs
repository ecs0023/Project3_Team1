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


    public void Start()
    {
        door1 = GameObject.Find("Door1");
    }
    public void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
           
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
            Destroy(collision.gameObject);

        }
    }
    private void UnlockDoor()
    {
        Debug.Log("Door Is Unlocked");
        Destroy(door1);
    }
    
}
