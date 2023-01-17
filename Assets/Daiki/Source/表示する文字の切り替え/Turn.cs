using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    private Text turnText = null;

    // Start is called before the first frame update
    void Start()
    {
        turnText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            turnText.text = "説明";
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
    }
    // Update is called once per frame
    void Update()
    {
        if (GManager.instance.turn==0){
            turnText.text = "収支";
            if((GManager.instance.year==0)&&(GManager.instance.time==0))turnText.text = "開始";
        }
        else if (GManager.instance.turn==1)turnText.text = "依頼";
        else if (GManager.instance.turn==2)turnText.text = "調査";
        else turnText.text = "結果";
    }
}
