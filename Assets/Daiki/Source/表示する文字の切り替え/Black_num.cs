using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Black_num : MonoBehaviour
{
    private Text comText = null;
    public GameObject map;
    ProductBlackco black;
    public bool BoW=true;
    // Start is called before the first frame update
    void Start()
    {
        black = map.GetComponent<ProductBlackco>();
        comText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            if(BoW)comText.text = "ホワイト企業"+3+"社";
            else comText.text = "ブラック企業"+1+"社";
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BoW)comText.text = "ホワイト企業"+(4-black.BlackCo)+"社";
        else comText.text = "ブラック企業"+black.BlackCo+"社";
    }
}
