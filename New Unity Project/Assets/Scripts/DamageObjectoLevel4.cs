using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObjectoLevel4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject roundEndDisplay;
    public GameObject questionDisplay;

    void onCollisionEnter2D(Collision2D collision )
    {
        if (collision.gameObject.tag == "Enemy" )
        {
            Debug.Log("Enemy");

        }
        
    }

}
