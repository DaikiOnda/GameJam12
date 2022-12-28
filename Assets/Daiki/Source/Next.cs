using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public GameObject  benefit;
    public GameObject black;
    public GameObject searcher;
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
        if(((GManager.instance.time)%12==0)&&flag){
            produckblackco.Duringproduct=31;
            flag=false;
            if((GManager.instance.time)%24==0){
                year++;
                if(year==3){
                    produckblackco.Days=400;
                }
            }
        }
        else if((GManager.instance.time)%12!=0) flag=true;
    }
    //ボタンを押すと次のターンに
    public void GoNextTurn()
    {
        searchreply.Searchbool=false;
        searchreply.panel.SetActive(false);
        //searchreply.reaction.SetActive(false);
        searchreply.Waittime=false;
        GManager.instance.turn=(GManager.instance.turn+1)%4;
        benefit.SetActive(false);
        if(GManager.instance.turn==2){
            searchreply.Searchbool=true;
        }
        else{
            if(GManager.instance.turn==0){
                GManager.instance.time=(GManager.instance.time+1)%24;
                //毎月1日に利益の獲得
                if(GManager.instance.time%2==0){
                    benefit.SetActive(true);
                    GManager.instance.budget+=GManager.instance.profit;
                }
                else    GManager.instance.turn=(GManager.instance.turn+1)%4;
            }
            //searchreply.Searchbool=false;
        }

    }
    //ボタンを押すと半月後に
    public void GoNextTime()
    {
        GManager.instance.turn=0;
        GManager.instance.time=(GManager.instance.time+1)%24;
        //毎月1日に利益の獲得
        if(GManager.instance.time%2==0){
            GManager.instance.budget+=GManager.instance.profit;
        }
    }
}
