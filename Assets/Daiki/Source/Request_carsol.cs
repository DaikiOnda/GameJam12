using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request_carsol : MonoBehaviour
{
    //GameObject型の変数sphereを宣言します。
    public GameObject company;
    public GameObject explain;
    Searchreply searchreply;
    private void OnMouseOver()
    {
        Vector3 mousePosition = Input.mousePosition;
        if((GManager.instance.turn==1)&&GManager.instance.request_go&&(!GManager.instance.alart)&&(!GManager.instance.serect)) explain.SetActive(true);
        GManager.instance.company_name=company.name;
    }

    //マウスカーソルがSphereの上から離れた時の処理
    private void OnMouseExit()
    {
        explain.SetActive(false);
        if(!GManager.instance.serect) GManager.instance.company_name="未選択";
    }
}
