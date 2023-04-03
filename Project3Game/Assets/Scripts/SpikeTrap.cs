using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeTrap : MonoBehaviour
{
    public int lives = 2;
    void Start()
    {
        
    }

    void Update()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene("Final");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Hazard")
        {
            lives--;
            Debug.Log("Player Got Hit");
        }


    }
}
