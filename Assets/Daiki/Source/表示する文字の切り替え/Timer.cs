using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timeText = null;
    private int month=4;
    private int days=1;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            timeText.text = (GManager.instance.year+1)+"年目"+month+"月"+days+"日";
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
    }
    // Update is called once per frame
    void Update()
    {
        month=((GManager.instance.time+6)%24+2)/2;
        /*if((GManager.instance.time+8)%24==0){

        }
        else */if(GManager.instance.time%2==0)days=1;
        else days=15;
            timeText.text = (GManager.instance.year+1)+"年目"+month+"月"+days+"日";
    }
}
