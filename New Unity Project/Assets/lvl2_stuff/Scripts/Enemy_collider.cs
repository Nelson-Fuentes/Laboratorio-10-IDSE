using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_collider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("not working at all!");
        if (collision.gameObject.CompareTag("Player")){
            Debug.Log("it comes here!");
            Character_controller player = collision.GetComponent<Character_controller>();
            if(player){
                player.restart();
            }
        }
 
    }
}
