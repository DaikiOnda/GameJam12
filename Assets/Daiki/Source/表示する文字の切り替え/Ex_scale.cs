using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex_scale : MonoBehaviour
{
    private Text turnText = null;
    private string company;
    private int company_num;

    // Start is called before the first frame update
    void Start()
    {
        turnText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            turnText.text = "十分な条件";
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
    }
    // Update is called once per frame
    void Update()
    {
        company=GManager.instance.company_name.Replace("企業","");
        company_num=int.Parse(company)-1;
        turnText.text =GManager.instance.reaction[GManager.instance.company_reaction[company_num,1]];
    }
}
