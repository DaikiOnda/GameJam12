using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Budget : MonoBehaviour
{
    private Text budgetText = null;
    private int oku=0;
    private int man=1000;
    // Start is called before the first frame update
    void Start()
    {
        budgetText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            budgetText.text = "予算 "+man+"万";
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
    }
    // Update is called once per frame
    void Update()
    {
        oku=GManager.instance.budget/10000;
        man=GManager.instance.budget%10000;
        if(oku>0)   budgetText.text = "予算 "+oku+"億"+man+"万";
        else   budgetText.text = "予算 "+man+"万";
    }
}
