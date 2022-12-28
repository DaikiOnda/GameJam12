using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serect_action : MonoBehaviour
{
    public GameObject send_request;
    public GameObject search;
    public GameObject exposed;
    public GameObject explain;
    void OnEnable() {
        explain.SetActive(false);
        GManager.instance.serect=true;
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
		GManager.instance.serect=false;
	}
}
