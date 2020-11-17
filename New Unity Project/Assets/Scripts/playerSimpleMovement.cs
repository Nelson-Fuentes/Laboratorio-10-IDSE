using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSimpleMovement : MonoBehaviour
{

    private const float SPEED = 5f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }
    private void HandleMovement()
    {
        float moveX = 0f;
        float moveY = 0f;
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveY = +1f;
            this.animator.SetTrigger("walk_up");
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveY = -1f;
            this.animator.SetTrigger("walk_down");
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveX = -1f;
            this.animator.SetTrigger("walk_left");
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveX = +1f;
            this.animator.SetTrigger("walk_rigth");
        }
        Vector3 moveDir = new Vector3(moveX, moveY).normalized;

        transform.position += moveDir * SPEED * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("muere");
    }
}
