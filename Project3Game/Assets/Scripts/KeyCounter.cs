using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class KeyCounter : MonoBehaviour
{
    public int countCollisions = 9;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public void Start()
    {
        door1 = GameObject.Find("Door1");
        door2= GameObject.Find("Door2");
        door3 = GameObject.Find("Door3");
    }
    public void Update()
    {

    }

    public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            countCollisions--;
            Destroy(collision.gameObject);
            Debug.Log("KeyCollected");
        }
        if (countCollisions == 6)
        {
            UnlockDoor();
        }
        if (countCollisions == 3)
        {
            UnlockDoor2();
        }
        if (countCollisions == 0)
        {
            UnlockDoor3();
        }


    }
    private void UnlockDoor()
    {
        
        Debug.Log("Unlocked Door");
        Destroy(door1);
    }

    private void UnlockDoor2()
    {

        Debug.Log("Unlocked Door");
        Destroy(door2);
    }

    private void UnlockDoor3()
    {

        Debug.Log("Unlocked Door");
        Destroy(door3);
    }
}
