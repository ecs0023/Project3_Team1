using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class KeyCounter : MonoBehaviour
{
    public int countCollisions = 3;
    public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Key")
            countCollisions--;
            Destroy(collision.gameObject);
            Debug.Log("KeyCollected");
            
        if (countCollisions <= 0)
        {
            UnlockDoor();
        }  
    }
    private void UnlockDoor()
    {
        var Door1 = GameObject.FindWithTag("Door1");
        Debug.Log("Unlocked Door");
        Destroy(Door1);
    }
}
