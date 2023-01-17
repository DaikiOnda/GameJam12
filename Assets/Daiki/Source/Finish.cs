using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GManager.instance.company_name="未選択";
        GManager.instance.alart=false;
        GManager.instance.serect=false;
        GManager.instance.turn=0;
        GManager.instance.time=0;
        GManager.instance.year=0;
        GManager.instance.plus=0;
        GManager.instance.budget=500000;//予算
    }

    // Update is called once per frame
    void Update()
    {
        if(GManager.instance.year>2)
        {   
            //GManager.instance.year=-2;
            SceneManager.LoadScene("ResultScene");
            /*Invoke("GoResult", 1f);
            enabled = false;
            return;*/
        }
        
    }
    /*IEnumerator GoResult()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("ResultScene");
    }*/
}
