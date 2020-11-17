﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_controller : MonoBehaviour {

    public float speed = 0.1f;
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        vertical  = Input.GetAxis("Vertical");
        //Debug.Log("Horizontal --> "+horizontal);
      //  Debug.Log("Vertical --> "+vertical);
        //looking
        //0 - > down
        //1 - > up
        //2 - > left
        //3 - > right
        if(horizontal>0){
            animator.SetInteger("looking",3);
            animator.SetBool("moving",true);      
        }
        if(horizontal<0){
            animator.SetInteger("looking",2);
            animator.SetBool("moving",true);
        }
        if(vertical>0){
            animator.SetInteger("looking",1);
            animator.SetBool("moving",true);
        }
        if(vertical<0){
            animator.SetInteger("looking",0);
            animator.SetBool("moving",true);
        }
      
       // if(Mathf.Abs(horizontal) < )
        if (horizontal == 0 && vertical == 0){
            animator.SetBool("moving",false);
        }
    }
    void FixedUpdate(){
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical  * Time.deltaTime;
        
        rigidbody2d.MovePosition(position);
        
    }
}
