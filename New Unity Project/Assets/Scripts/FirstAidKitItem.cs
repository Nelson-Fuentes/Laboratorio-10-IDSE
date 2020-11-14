using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKitItem : MonoBehaviour
{
    public CollectFirstAidKit collector;
    public int value; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.collector.increaseFirstAid(this.value);
            Destroy(this.gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
