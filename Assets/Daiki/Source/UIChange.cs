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
    public GameObject market;
    public void RequestUI()
    {
        if(!GManager.instance.request_go){
            if(GManager.instance.turn==1) request.SetActive(true);
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
    }
    public void alarmBUIclose(){
        alarmB.SetActive(false);
    }
    public void alarmCUIclose(){
        alarmC.SetActive(false);
        GManager.instance.alart=false;
    }
    public void alarmDUIclose(){
        alarmD.SetActive(false);
        GManager.instance.alart=false;
    }
    public void requestUIclose(){
        request.SetActive(false);
    }
    public void marketUIclose()
    {
        market.SetActive(false);
    }
}
