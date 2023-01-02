using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benefit : MonoBehaviour
{
    public GameObject map;
    ProductBlackco black;
    private bool first=true;

    void OnEnable() {
        if(first){
            black = map.GetComponent<ProductBlackco>();
            first=false;
        }
        else{
            black.ResultTurnbool=true;
        }
        //GManager.instance.budget+=(GManager.instance.profit*(4-black.BlackCo)-GManager.instance.loss*black.BlackCo);
    }
    public void up(){
        if((!GManager.instance.request_go)&&(GManager.instance.time%2==0)){
            if(first){
                black = map.GetComponent<ProductBlackco>();
                first=false;
            }
            else{
                black.BlackCo=0;
                black.ResultTurnbool=true;
            }
            while(!black.ResultTurnbool);
            //GManager.instance.budget=GManager.instance.budget+GManager.instance.profit*(4-black.BlackCo)-GManager.instance.loss*black.BlackCo;
        }
    }
    void OnDisable() {
        GManager.instance.budget=GManager.instance.budget+(GManager.instance.profit*(10+GManager.instance.plus)/10)*(4-black.BlackCo)-(GManager.instance.loss*(20+GManager.instance.plus)/20)*black.BlackCo;
        black.AfterresultReset=true;
	}
}
