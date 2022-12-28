using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequestBudgetU : MonoBehaviour
{
    public InputField inputField;
    public GameObject  request_botton;
    public GameObject alarm;
 
    void Start () {
    //Componentを扱えるようにする
        inputField = inputField.GetComponent<InputField> ();
    }
    public void input(){
        if(GManager.instance.req_budget_lower[GManager.instance.scale[GManager.instance.create_req]]<int.Parse(inputField.text)){
            GManager.instance.req_budget_upper[GManager.instance.create_req]=int.Parse(inputField.text);
            request_botton.SetActive(true);
        }    
       //警告の表示
        else{
            alarm.SetActive(true);
            request_botton.SetActive(false);
        }  
    }
}
