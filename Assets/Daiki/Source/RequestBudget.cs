using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequestBudget : MonoBehaviour
{
    private Text budgetText = null;
    private int man=50;
    // Start is called before the first frame update
    void Start()
    {
        budgetText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            budgetText.text =man+"万";
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
    }
    // Update is called once per frame
    void Update()
    {
        switch (GManager.instance.scale[GManager.instance.create_req])
        {
            case 0:
                man=50;
                break;
            case 1:
                man=200;
                break;
            case 2:
                man=500;
                break;
            case 3:
                man=1000;
                break;
            case 4:
                man=2000;
                break;
        }
        budgetText.text =man+"万";
    }
}
