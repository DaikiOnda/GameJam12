using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex_money : MonoBehaviour
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
            turnText.text = "断ります";
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
        if(GManager.instance.company_reaction[company_num,0]!=0){
            //if((GManager.instance.company_reaction[company_num-1,0]/10000)>0){
             //   turnText.text=GManager.instance.company_reaction[company_num,0]/10000+"億"+turnText.text=GManager.instance.company_reaction[company_num,0]%10000+"万";
            //}
            turnText.text=GManager.instance.company_reaction[company_num,0]+"万";
        }
        else turnText.text = "断ります";
    }
}
