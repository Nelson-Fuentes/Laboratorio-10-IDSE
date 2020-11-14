using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayerLevel3 : MonoBehaviour
{
    public Animator animator;
    public float velocity = 1f;
    public float acceleration = 0.2f;
    public DialogueControllerLevel3 dialogue;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocity * Time.deltaTime;
            this.velocity += acceleration;
            this.animator.SetTrigger("walk_left");
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocity * Time.deltaTime;
            this.velocity += acceleration;
            this.animator.SetTrigger("walk_rigth");
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * velocity * Time.deltaTime;
            this.velocity += acceleration;
            this.animator.SetTrigger("walk_down");
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * velocity * Time.deltaTime;
            this.velocity += acceleration;
            this.animator.SetTrigger("walk_up");
        }
        transform.rotation = Quaternion.identity;
    }
}
