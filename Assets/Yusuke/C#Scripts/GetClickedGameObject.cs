using UnityEngine;
using UnityEngine.UI;
public class GetClickedGameObject : MonoBehaviour {
 
    GameObject clickedGameObject;
    public GameObject panel;
    public GameObject reaction;
    public Searchreply Sr;
    bool Waittime = false;//Buttonを押すまでUpdateの中身の挙動を止める
    public Text text;
void Update()
{
    if(Sr.Searchbool==true)//When turn is Searchturn,this content will be conducted
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
      public void OnClick()
    {
         //クリックされたオブジェクトの看板を下げる
            GameObject childObject = clickedGameObject.transform.Find("sign").gameObject;
            childObject.SetActive(false);
            panel.SetActive(false);
            reaction.SetActive(true);
            text.text="この会社は残業代を\n   払っていなかった";
            Waittime=false;
    }
}