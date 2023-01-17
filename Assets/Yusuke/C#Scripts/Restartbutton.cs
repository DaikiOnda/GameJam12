using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restartbutton : MonoBehaviour
{
    // Start is called before the first frame update
   private float step_time=0.0f;
   bool timer =false;
   
   void Update(){
   if(timer) step_time += Time.deltaTime;
    //3秒後にメソッドを実行する
   if(step_time >= 2.0f)
        SceneManager.LoadScene("StartScene");
   }
    public void Onclick(){
        Debug.Log("ボタンが押されました！");
         timer=true;
    }
   
}
