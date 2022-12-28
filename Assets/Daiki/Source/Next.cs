using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public GameObject  benefit;
    public GameObject black;
    ProductBlackco produckblackco;
    //BlackC blackC;
    void Start () {
        produckblackco = black.GetComponent<ProductBlackco>();
    }
    void Update()
    {
        if((GManager.instance.time)%12==0){
            produckblackco.Duringproduct=31;
        }
        
    }
    //ボタンを押すと次のターンに
    public void GoNextTurn()
    {
        GManager.instance.turn=(GManager.instance.turn+1)%4;
        benefit.SetActive(false);
        if(GManager.instance.turn==0){
            GManager.instance.time=(GManager.instance.time+1)%24;
            //毎月1日に利益の獲得
            if(GManager.instance.time%2==0){
                benefit.SetActive(true);
                GManager.instance.budget+=GManager.instance.profit;
            }
            else    GManager.instance.turn=(GManager.instance.turn+1)%4;
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
