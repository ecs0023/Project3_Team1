using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class KeyCounter : MonoBehaviour
{
    public int countCollisions = 3;
    public GameObject door;
    public void Start()
    {
        door = GameObject.Find("Door1");
    }
    public void Update()
    {
        if (countCollisions <= 0)
        {
            UnlockDoor();
        }
    }

    public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            countCollisions--;
            Destroy(collision.gameObject);
            Debug.Log("KeyCollected");
        }
            
            
    }
    private void UnlockDoor()
    {
        
        Debug.Log("Unlocked Door");
        Destroy(door);
    }
}
