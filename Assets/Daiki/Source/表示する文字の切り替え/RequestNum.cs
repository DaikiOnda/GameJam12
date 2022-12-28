using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequestNum : MonoBehaviour
{
    private Text requestText = null;
    // Start is called before the first frame update
    void Start()
    {
        requestText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            requestText.text = "依頼数 "+GManager.instance.request+"/"+GManager.instance.requestlimit;
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
    }
    // Update is called once per frame
    void Update()
    {
        if (GManager.instance.turn==1)requestText.text = "依頼数 "+GManager.instance.request+"/"+GManager.instance.requestlimit;
        else if (GManager.instance.turn==2)requestText.text = "調査数"+GManager.instance.watch+"/"+GManager.instance.watchlimit;
    }
}
