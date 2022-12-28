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
        man=GManager.instance.req_budget_lower[GManager.instance.scale[GManager.instance.create_req]];
        budgetText.text =man+"万";
    }
}
