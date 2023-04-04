using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SpikeTrap : MonoBehaviour
{
    public int lives = 2;
    void Start()
    {
        
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lives--;
            Debug.Log("Player Got Hit");
        }

        if (lives <= 0)
        {
            Debug.Log("Lives goes to zero");
            ShowPanel();
        }


    }
    public void ShowPanel()
    {
        SceneManager.LoadScene("EndGame");
    }
}
