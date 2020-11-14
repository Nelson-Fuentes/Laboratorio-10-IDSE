using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControllerLevel3 : MonoBehaviour
{
    private float time = 0.0f;
    public float interpolationPeriod = 5.0f;
    public Text text;
    // Start is called before the first frame update
    void Awake()
    {
        this.setText("Entraste al almacen del hospital, Es probable que encuentres botiquines de primeros auxilios aqui.");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            time = 0;
            text.text = "";
        }
    }

    public void setText(string text)
    {
        time = 0;
        this.text.text = text;
    }
}
