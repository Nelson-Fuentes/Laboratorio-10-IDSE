using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerLevel3 : MonoBehaviour
{
    public InDanger inDanger;
    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.inDanger.getDamage(this.damage);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.inDanger.outDanger(this.damage);
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
