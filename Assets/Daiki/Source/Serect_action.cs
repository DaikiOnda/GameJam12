using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serect_action : MonoBehaviour
{
    public GameObject select;
    public GameObject alarmG;
    public GameObject send_request;
    public GameObject search;
    public GameObject exposed;
    public GameObject explain;
    public GameObject actionUI;
    public GameObject del;
    void OnEnable() {
        del.SetActive(true);
        actionUI.SetActive(false);
        explain.SetActive(false);
        GManager.instance.serect=true;
        /*if(GManager.instance.watch==GManager.instance.watchlimit){
            select.SetActive(false);
            alarmG.SetActive(true);
            GManager.instance.company_name="未選択";
        }
        else   {
            GManager.instance.watch++;
        }*/
        if(GManager.instance.turn==1){
            send_request.SetActive(true);
            search.SetActive(false);
            exposed.SetActive(false);
        }
        else if(GManager.instance.turn==2){
            send_request.SetActive(false);
            search.SetActive(true);
            exposed.SetActive(true);
        }   
        else{
            send_request.SetActive(false);
            search.SetActive(false);
            exposed.SetActive(false);

        } 
		Debug.Log("OnEnable");
	}
    void OnDisable() {
        del.SetActive(false);
        actionUI.SetActive(true);
		GManager.instance.serect=false;
	}
}
