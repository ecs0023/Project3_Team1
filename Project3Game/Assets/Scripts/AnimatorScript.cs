using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim=GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isMovingRight", true);
        }
        else
        {
            anim.SetBool("isMovingRight", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isMovingLeft", true);
        }
        else
        {
            anim.SetBool("isMovingLeft", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isMovingUp", true);
        }
        else
        {
            anim.SetBool("isMovingUp", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isMovingDown", true);
        }
        else
        {
            anim.SetBool("isMovingDown", false);
        }
    }
}
