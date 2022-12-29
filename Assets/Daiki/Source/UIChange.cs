using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChange : MonoBehaviour
{
    public GameObject  request;
    public GameObject  enhancement;
    public GameObject alarm;
    public GameObject alarmB;
    public GameObject alarmC;
    public GameObject alarmD;
    public GameObject alarmE;
    public GameObject alarmF;
    public GameObject alarmG;
    public GameObject market;
    public GameObject select;
    public GameObject searcher;
    Searchreply searchreply;
    void Start () {
        searchreply = searcher.GetComponent<Searchreply>();
    }
    public void RequestUI()
    {
        if(!GManager.instance.request_go){
            
            if(GManager.instance.turn==1){
                if(GManager.instance.request<GManager.instance.requestlimit){
                    request.SetActive(true);
                }
                else alarmF.SetActive(true);
            } 
        }
        else{
            alarmC.SetActive(true);
            GManager.instance.alart=true;
        } 
    }
    public void EnhancementUI()
    {
        enhancement.SetActive(true);
    }
    public void MarketUI()
    {
        market.SetActive(true);
    }
    public void alarmUIclose(){
        alarm.SetActive(false);
        searchreply.Searchbool=false;
    }
    public void alarmBUIclose(){
        alarmB.SetActive(false);
    }
    public void alarmCUIclose(){
        alarmC.SetActive(false);
        searchreply.Searchbool=false;
        GManager.instance.alart=false;
        GManager.instance.company_name="未選択";
    }
    public void alarmDUIclose(){
        alarmD.SetActive(false);
        searchreply.Searchbool=false;
        GManager.instance.alart=false;
        GManager.instance.company_name="未選択";
    }
    public void alarmEUIclose(){
        alarmE.SetActive(false);
        searchreply.Searchbool=false;
        GManager.instance.refuse=0;
        GManager.instance.company_name="未選択";
    }
    public void alarmFUIclose(){
        alarmF.SetActive(false);
        searchreply.Searchbool=false;
        GManager.instance.refuse=0;
        GManager.instance.company_name="未選択";
    }
    public void alarmGUIclose(){
        alarmG.SetActive(false);
        searchreply.Searchbool=false;
        GManager.instance.refuse=0;
        GManager.instance.company_name="未選択";
    }
    public void requestUIclose(){
        request.SetActive(false);
    }
    public void marketUIclose()
    {
        market.SetActive(false);
    }
    public void selectUIclose()
    {
        select.SetActive(false);
        searchreply.Searchbool=false;
        GManager.instance.company_name="未選択";
        //searchreply.Waittime=false;
    }
}
