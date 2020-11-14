using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 position;
    
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + position;
    }
}
