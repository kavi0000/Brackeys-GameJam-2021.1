﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public CharacterController2D controller;

    public float horizontalMove = 0f;

    public float speed = 40f;

    bool crouch = false;

    bool jump = false;

    public Animator animator;

    public AudioSource jumpSound;

    public void Update ()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            jumpSound.Play();
            
        }

        //if (Input.GetKeyDown(KeyCode.LeftControl))
        //{
            //crouch = true;
        //} else if (Input.GetKeyUp(KeyCode.LeftControl))
       // {
           // crouch = false;
       // }
    }

    

    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }




}
