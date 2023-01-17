using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money_control : MonoBehaviour
{
    public GameObject panel;
    public GameObject searcher;
    Searchreply searchreply;
    //public  ProductBlackco black;
    void Start () {
        searchreply = searcher.GetComponent<Searchreply>();
    }
    void update()
    {

    }   
    public void send(){
        string company;
        int company_num;
        company=GManager.instance.company_name.Replace("企業","");
        company_num=int.Parse(company)-1;
        GManager.instance.budget=GManager.instance.budget-GManager.instance.company_reaction[company_num,0];
        panel.SetActive(false);
        GManager.instance.plus=GManager.instance.plus+GManager.instance.scale[GManager.instance.create_req];
        GManager.instance.request_go=false;
        searchreply.Waittime=false;
        GManager.instance.request+=1;
        GManager.instance.create_req+=1;
    }
    public void reset(){
        searchreply.Waittime=false;
    }
}
