﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    Animator animator;
    // private CharacterController controler;
    public float speed = 12f;
    
    private float jump= 10.0f;

    Vector3 Y;
    Vector3 moveObj;
    bool ener = false;
    public bool move = false;
    void Start()
    {
        animator = GetComponent<Animator>();
        // controler = GetComponent<CharacterController>();

    }
    void Update()
    {

        float x = speed * Input.GetAxis("Horizontal");
        float y = speed * Input.GetAxis("Vertical");
        
        float velocity = 0;

        if (Input.GetButton("Jump")){
            velocity = jump;
            print("jump");
            animator.SetFloat("jump", velocity);
        }
        else
        {
            animator.SetFloat("jump", 0);
        }

        if (Input.GetAxis("Vertical") != 0 && ener != true && move != true)
        {
            animator.SetFloat("run", y);
        } else {
            animator.SetFloat("run", 0);
        }


        moveObj =  new Vector3(speed * Input.GetAxis("Horizontal")*Time.deltaTime,
                                velocity*Time.deltaTime,
                                speed * Input.GetAxis("Vertical")*Time.deltaTime);
        transform.Translate(moveObj);
    }

    public void setSpeed(int energi)
    {
        if (energi <= 500)
        {
            this.speed = 8f;
        }

        if (energi < 0)
        {
            ener = true;
        }
    }
}