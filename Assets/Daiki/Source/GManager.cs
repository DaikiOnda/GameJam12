using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public bool[] coBW={true,false,false,true};
    public static GManager instance = null; 
    public int company_amount=0;
    public int turn=0;
    public int time=0;
    public int request=0;
    public int requestlimit=1;
    public int budget=1000;
    public int profit;
    public int create_req;
    public int[] scale={0,0,0,0};
    public int[] deadline={0,0,0,0};
    public int[] market_deadline={3,7,11,13,17};//ターン数目安
    public int[] req_budget_lower={50,200,500,1000,2000};//予算の下限表示用
    public int[] req_market_price={200,500,1000,2000,3000,4000};//相場の値段
    public int[] req_budget_upper={-1,-1,-1,-1};//依頼の予算の上限値を記録する配列
    public string[] reaction={"規模が大きい","期限が短い","予算が少ない","十分な条件","期限が長い"};
    public int[,] company_reaction={{0,3,3,3},{0,3,3,3},{0,3,3,3},{0,3,3,3}};//各企業の反応を記録する配列{値段(0は依頼の拒否),規模への反応,期限への反応,予算への反応}
    public int[,] company_status={{2,14,1},{3,13,0},{3,15,1},{4,14,2}};//規模上限,黒時の予算の補正,期限下限
    /*public struct CompanyStatus{
        public int cId;
        public bool black;
        public int timer;
        public int Mlimit;
        public int Tlimit;
        public int Dlimit;
        public int Mcorrection;
        public int Tcorrection;
        public int Dcorrection;
    
        public CompanyStatus(int p1, bool p2,int p3,int p4,int p5,int p6,int p7,int p8,int p9)
        {
            this.cId = p1;
            this.black = p2;
            this.timer = p3;
            this.Mlimit = p4;
            this.Tlimit = p5;
            this.Dlimit = p6;
            this.Mcorrection = p7;
            this.Tcorrection = p8;
            this.Dcorrection = p9;
        }
    }
    private CompanyStatus[] coList = {
            new CompanyStatus(0,true,0,10,1,2,100,1,3),
            new CompanyStatus(1,false,0,10,1,3,100,1,3),
            new CompanyStatus(2,false,0,10,1,4,100,1,1),
            new CompanyStatus(3,false,0,10,1,3,100,1,2),
            new CompanyStatus(-1,false,0,0,0,0,0,0,0)    // -1は、終端の意味として使う
    };*/

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