using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class InDanger : MonoBehaviour
{

    public Image lineDanger;
    public Image lineShield;
    public float shield;
    private float danger;
    private float minDanger;
    private float maxDanger;
    private float minShield;
    private float maxShield;
    private float time = 0.0f;
    public float interpolationPeriod = 5.0f;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        danger = 0;
        maxDanger = 1;
        maxShield = 1;
        minDanger = 0;
    }

    // Update is called once per frame
    void Update()
    {
        lineDanger.fillAmount = danger;
        lineShield.fillAmount = shield;
        if (danger >= maxDanger)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void getDamage(float damage)
    {

        if (shield > minShield)
        {
            shield -= damage;
        }
        else if (danger < maxDanger)
        {
            danger += damage;
        }
    }

    public void outDanger(float danger)
    {
        if (danger > minDanger)
        {
            danger -= danger;
        }
        else if (shield < maxShield)
        {
            shield += danger/0.4f;
        }
    }
}
