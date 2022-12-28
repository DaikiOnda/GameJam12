using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex_company_name : MonoBehaviour
{
    private Text timeText = null;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            timeText.text = GManager.instance.company_name;
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); }
    }
    // Update is called once per frame
    void Update()
    {
        timeText.text = GManager.instance.company_name;
    }
}
