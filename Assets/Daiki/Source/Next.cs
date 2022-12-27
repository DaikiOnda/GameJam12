using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    //ボタンを押すと次のターンに
    public void GoNextTurn()
    {
        GManager.instance.turn=(GManager.instance.turn+1)%4;
        if(GManager.instance.turn==0)GManager.instance.time=(GManager.instance.time+1)%24;
    }
    public void GoNextTime()
    {
        GManager.instance.turn=0;
        if(GManager.instance.turn==0)GManager.instance.time=(GManager.instance.time+1)%24;
    }
}
