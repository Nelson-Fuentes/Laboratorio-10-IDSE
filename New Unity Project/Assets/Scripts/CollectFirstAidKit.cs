using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectFirstAidKit : MonoBehaviour
{
    private int firstAidKitCount;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        this.firstAidKitCount = 0;
    }

    void Update()
    {
        text.text = "X " + this.firstAidKitCount;
    }


    public void increaseFirstAid(int increase)
    {
        this.firstAidKitCount += increase;
    }

    public int getFirtAidKitCount()
    {
        return this.firstAidKitCount;
    }
}
