using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money_control : MonoBehaviour
{
    public GameObject panel;
    public GameObject searcher;
    Searchreply searchreply;
    void Start () {
        searchreply = searcher.GetComponent<Searchreply>();
    }

    public void send(){
        string company;
        int company_num;
        company=GManager.instance.company_name.Replace("企業","");
        company_num=int.Parse(company)-1;
        GManager.instance.budget=GManager.instance.budget-GManager.instance.company_reaction[company_num,0];
        panel.SetActive(false);
        GManager.instance.request_go=false;
        searchreply.Waittime=false;
    }
    public void reset(){
        searchreply.Waittime=false;
    }
}
