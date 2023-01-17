using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result_money : MonoBehaviour
{
    private Text moneyText = null;
    public GameObject map;
    ProductBlackco black;
    public bool BoW=true;
    // Start is called before the first frame update
    void Start()
    {
        black = map.GetComponent<ProductBlackco>();
        moneyText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            if(BoW)moneyText.text = GManager.instance.profit*3+"万増加";
            else moneyText.text = GManager.instance.loss+"万減少";
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BoW)moneyText.text = (GManager.instance.profit*(10+GManager.instance.plus)/10)*(4-black.BlackCo)+"万増加";
        else moneyText.text = (GManager.instance.loss*(20+GManager.instance.plus)/20)*black.BlackCo+"万減少";
    }
}
