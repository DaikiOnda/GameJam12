using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProductBlackco : MonoBehaviour //CompanyinfoからCo1～Co４までのboolの値を持ってくる
{
public int Days = 0;//4箇所すべてがブラック企業になるまでの日数
public int Duringproduct = 0;//ブラック企業がランダムで増えるまでの日数
public int BlackCo =0;//ブラック企業の会社の数を代入
public bool ResultTurnbool=false;//結果のターンが来た時にtrue
public bool AfterresultReset=false;//結果のターンが終わった後に、ブラック企業のカウントを初期化
public Companyinfo com;

void Update()
    {
        if(Days>=365)//365日が過ぎて、なかにBlack企業がいるかどうか
        {
            if(BlackCo >= 1)//もしブラック企業が１つ以上でもあれば、その範囲の会社はすべてBlackになる
            {
            for(int i=0;i<4;i++)com.Co[i] = false;//周りの４社をBlack企業にする
            }
            
            Days = 0;//日数を戻す
        }



    if(Duringproduct>=30)
    {
        int rnd = Random.Range(1, 5);　// ※ 1～4の範囲でランダムな整数値が返る
    switch(rnd) {
        case 1:
            com.Co[0]=false;
            break;
        case 2:
            com.Co[1]=false;
            break;
        case 3:
            com.Co[2]=false;
            break;
        case 4:
            com.Co[3]=false;
            break;
             }Duringproduct=0;
    }


        if(ResultTurnbool==true){//結果ターンが来た時に、ブラック企業の数を確認
            for(int i=0;i<4;i++)
            {
                if(com.Co[i]==false)
                {
                    BlackCo++;
                }else{
                    if(BlackCo>0) BlackCo--;
                }
            }
            ResultTurnbool=false;//実行後はfalse
        }
        if(AfterresultReset==true)
        {
            BlackCo=0;
            AfterresultReset=false;//実行後はfalse
        }
        
 }}