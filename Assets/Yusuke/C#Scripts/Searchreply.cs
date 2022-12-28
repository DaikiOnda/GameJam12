using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Searchreply : MonoBehaviour
{
public Companyinfo com;
GameObject clickedGameObject;
public GameObject panel;//Buttonの非表示,表示の区分け
public GameObject reaction;
public Text text;
public bool Searchbool=false;//if this bool is true,you can get Update method
bool Waittime = false;//Buttonを押すまでUpdateの中身の挙動を止める
    // Update is called once per frame
   
void Update()
{
    if(Searchbool==true)//When turn is Searchturn,this content will be conducted
    {
        if(Waittime == false)
        {
           if (Input.GetMouseButtonDown(0)) 
           {//オブジェクトがクリックされたときこの中が実行される
 
                clickedGameObject = null;
 
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();
 
                if (Physics.Raycast(ray, out hit)) 
                {
                    clickedGameObject = hit.collider.gameObject;//クリックされたオブジェクトを代入
                }
           
               panel.SetActive(true);//Buttonの表示
               Debug.Log(clickedGameObject);
               Waittime=true;
                
            }
        }
            if(Input.GetKey(KeyCode.Escape))
            {   //escキーが押されたときに、Panel画面を元に戻す
                panel.SetActive(false);//Buttonの非表示
                reaction.SetActive(false);
                Waittime=false;
            }
    }
}
    
    public void OnClickSearch()//調査Buttonが押されたとき
    {
         //クリックされたオブジェクトの看板を上げる
          GameObject childObject = clickedGameObject.transform.Find("sign").gameObject;
          switch(clickedGameObject.name)
          {//クリックされた建物の名前がどれに当たるかの選別
            case "企業1":
                if(com.Co[0]==false){//もしその会社がブラックだったら看板を出す
                    childObject.SetActive(true);
                    text.text="この会社はブラック企業だった";
                    reaction.SetActive(true);
                }
                break;
            case "企業2":
                if(com.Co[1]==false){
                    childObject.SetActive(true);
                    text.text="この会社はブラック企業だった";
                    reaction.SetActive(true);
                }
                break;
            case "企業3":
                if(com.Co[2]==false){
                    childObject.SetActive(true);
                    text.text="この会社はブラック企業だった";
                    reaction.SetActive(true);
                }
                break;
            case "企業4":
                if(com.Co[3]==false){
                    childObject.SetActive(true);
                    text.text="この会社はブラック企業だった";
                    reaction.SetActive(true);
                }
            break;
          }
            
           panel.SetActive(false);//Button will be invisible
           Waittime=false;
    }
    
}
