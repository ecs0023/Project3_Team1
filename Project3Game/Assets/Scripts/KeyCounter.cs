using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class KeyCounter : MonoBehaviour
{

    public int countCollisions = 3;

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.name == "Key")
            countCollisions--;
        if (countCollisions == 0)
        {
            UnlockDoor();
        }  
    }
    private void UnlockDoor()
    {
        Debug.Log("Unlocked Door");
    }
}
