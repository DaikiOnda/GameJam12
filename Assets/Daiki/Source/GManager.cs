using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null; 
    public bool request_go=false;
    public int company_amount=4;
    public int create_req;//何個目の依頼か
    public int request=0;
    public int requestlimit=2;
    public int watch=0;
    public int watchlimit=1;
    public int refuse=0;//依頼を拒否した企業の数
    public int profit;
    public int loss;
    public int[] scale={0,0,0,0};
    public int[] deadline={0,0,0,0};
    public int[] market_deadline={3,7,11,13,17};//ターン数目安
    public int[] req_budget_lower={50,200,500,1000,2000};//予算の下限表示用
    public int[] req_market_price={200,500,1000,2000,3000,4000};//相場の値段
    public int[] req_budget_upper={-1,-1,-1,-1};//依頼の予算の上限値を記録する配列
    public string[] reaction={"規模が大きい","期限が短い","予算が少ない","十分な条件","期限が長い"};
    public int[,] company_reaction={{0,3,3,3},{0,3,3,3},{0,3,3,3},{0,3,3,3}};//各企業の反応を記録する配列{値段(0は依頼の拒否),規模への反応,期限への反応,予算への反応}
    public int[,] company_status={{2,14,1},{3,13,0},{3,15,1},{4,14,2}};//規模上限,黒時の予算の補正,期限下限
    
    public string company_name="未選択";
    public bool alart=false;
    public bool serect=false;
    public int turn=0;
    public int time=0;
    public int year=0;
    public int budget=500000;//予算
    void Start()
    {        
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}