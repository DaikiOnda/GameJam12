using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductBlackco : Companyinfo //CompanyinfoからCo1～Co４までのboolの値を持ってくる
{
[SerializeField] int Days = 365;//4箇所すべてがブラック企業になるまでの日数
[SerializeField] int Duringproduct = 30;//ブラック企業がランダムで増えるまでの日数
[SerializeField] int BlackCo =1;//ブラック企業の会社の数を代入

    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()
    {
        if(Days>=360)//30日が過ぎて、なかにBlack企業がいるかどうか
        {
            if(BlackCo >= 1)//もしブラック企業が１つ以上でもあれば、その範囲の会社はすべてBlackになる
            {
            Co1=false;//周りの４社をBlack企業にする
            Co2=false;//周りの４社をBlack企業にする
            Co3=false;//周りの４社をBlack企業にする
            Co4=false;//周りの４社をBlack企業にする
            }
            
            Days = 0;//日数を戻す
        }
        if(Duringproduct>=30)
        {
        int rnd = Random.Range(1, 5);　// ※ 1～4の範囲でランダムな整数値が返る
        switch(rnd) {
        case 1:
            Co1=false;
            break;
        case 2:
            Co2=false;
            break;
        case 3:
            Co3=false;
            break;
        case 4:
            Co4=false;
            break;
}

         Duringproduct=0;
        }
    }
    
}
