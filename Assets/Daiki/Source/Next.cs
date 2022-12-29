using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public GameObject  benefit;
    public GameObject black;
    public GameObject searcher;
    public GameObject alarmD;
    private bool flag=false;
    public int year=0;
    ProductBlackco produckblackco;
    Searchreply searchreply;
    //BlackC blackC;
    void Start () {
        produckblackco = black.GetComponent<ProductBlackco>();
        searchreply = searcher.GetComponent<Searchreply>();
    }
    void Update()
    {
        
        if(((GManager.instance.request_go)||(GManager.instance.turn==2))&&(GManager.instance.company_name!="未選択")){
            searchreply.Searchbool=true;
        }
        else{
            searchreply.Searchbool=false;
        }
        if(((GManager.instance.time)%12==0)&&flag){
            produckblackco.Duringproduct=31;
            flag=false;
            if((GManager.instance.time)%24==0){
                year++;
                //年の限界を決める
                if(year==10){
                    produckblackco.Days=400;
                }
            }
        }
        else if((GManager.instance.time)%12!=0) flag=true;
    }
    //ボタンを押すと次のターンに
    public void GoNextTurn()
    {
        if(GManager.instance.request_go){
            GManager.instance.alart=true;
            alarmD.SetActive(true);
        }
        else{
            GManager.instance.request=0;
            GManager.instance.watch=0;
            searchreply.Searchbool=false;
            searchreply.panel.SetActive(false);
            //searchreply.reaction.SetActive(false);
            searchreply.Waittime=false;
            GManager.instance.turn=(GManager.instance.turn+1)%4;
            benefit.SetActive(false);
            if(GManager.instance.turn!=2){
                if(GManager.instance.turn==3)GManager.instance.turn=(GManager.instance.turn+1)%4;
                if(GManager.instance.turn==0){
                    GManager.instance.time=(GManager.instance.time+1)%24;
                    //毎月1日に利益の獲得
                    if(GManager.instance.time%2==0){
                        benefit.SetActive(true);
                        //GManager.instance.budget+=(GManager.instance.profit-GManager.instance.loss);
                    }
                    else    GManager.instance.turn=(GManager.instance.turn+1)%4;
                }
                //searchreply.Searchbool=false;
            }
        }

    }
    //ボタンを押すと半月後に
    public void GoNextTime()
    {
        if(GManager.instance.request_go){
            GManager.instance.alart=true;
            alarmD.SetActive(true);
        }
        else{
            GManager.instance.request=0;
            GManager.instance.watch=0;
            GManager.instance.turn=0;
            GManager.instance.time=(GManager.instance.time+1)%24;
            //毎月1日に利益の獲得
            if(GManager.instance.time%2==0){
                benefit.SetActive(true);
                //GManager.instance.budget+=(GManager.instance.profit-GManager.instance.loss);
            }
            else    GManager.instance.turn=(GManager.instance.turn+1)%4;
        }
    }
}
