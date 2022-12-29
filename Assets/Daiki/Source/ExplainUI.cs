using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplainUI : MonoBehaviour
{
    public GameObject  ex;
    public GameObject  ex1;
    public GameObject  ex2;
    public GameObject ex3;
    public GameObject ex4;
    public GameObject next_turn;
    private int change=1;
    // Start is called before the first frame update
    void Start () {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void buck_ex(){
        if(change>1)change-=1;
        exUI();
    }
    public void next_ex(){
        change+=1;
        exUI();
    }
    public void exUI(){
        if(change<1){}
        else if(change==1){
            ex1.SetActive(true);
            ex2.SetActive(false);
            ex3.SetActive(false);
            ex4.SetActive(false);
        }
        else if(change==2){
            ex1.SetActive(false);
            ex2.SetActive(true);
            ex3.SetActive(false);
            ex4.SetActive(false);
        }
        else if(change==3){
            ex1.SetActive(false);
            ex2.SetActive(false);
            ex3.SetActive(true);
            ex4.SetActive(false);
        }
        else if(change==4){
            ex1.SetActive(false);
            ex2.SetActive(false);
            ex3.SetActive(false);
            ex4.SetActive(true);
        }
        else{
            ex1.SetActive(false);
            ex2.SetActive(false);
            ex3.SetActive(false);
            ex4.SetActive(false);
            ex.SetActive(false);
            next_turn.GetComponent<Next>().GoNextTurn();
        } 
    }
    public void del(){
        ex1.SetActive(false);
        ex2.SetActive(false);
        ex3.SetActive(false);
        ex4.SetActive(false);
        ex.SetActive(false);
        next_turn.GetComponent<Next>().GoNextTurn();
    }
}
