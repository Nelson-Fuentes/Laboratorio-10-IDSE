using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevel3 : MonoBehaviour
{
    public CollectFirstAidKit collector;
    public DialogueControllerLevel3 dialogue;
    public int necesary;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collector.getFirtAidKitCount() >= necesary)
            {
                dialogue.setText("Ganaste");
            } else
            {
                dialogue.setText("Eso no es suficiente minimo necesitamos " + necesary);
            }
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
