using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequestTitle : MonoBehaviour
{
    private Text requestText = null;
    // Start is called before the first frame update
    void Start()
    {
        requestText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            requestText.text = "依頼" + (GManager.instance.create_req+1);
        }
        else
        {
            Debug.Log("ゲームマネージャー置き忘れてるよ！");
            Destroy(this); 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        requestText.text = "依頼" + (GManager.instance.create_req+1);
        
    }
}
