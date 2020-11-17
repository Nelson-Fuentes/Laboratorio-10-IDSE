using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorLevel4 : MonoBehaviour
{
    public float visionRadious;

    public float speed;
    public GameObject player;
    Vector3 initialPosition; 

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = initialPosition;
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadious)
        {
            target = player.transform.position;
        }

        float fixedSpeed = speed*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);
        Debug.DrawLine(transform.position, target, Color.green); 

    }
    

}
