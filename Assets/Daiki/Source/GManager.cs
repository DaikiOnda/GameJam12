using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null; 
    public int turn=0;
    public int time=0;
    public int request=0;
    public int requestlimit=1;
    public int budget=1000;
    public int profit;
    public int create_req;
    public int[] scale={0,0,0,0};
    public int[] deadline={0,0,0,0};
    public int[] req_budget_lower={50,200,500,1000,2000};
    public int[] req_budget_upper={-1,-1,-1,-1};
    public int[] company_reaction={-1,-1,-1,-1};
    public bool[] black={};
    public struct CompanyStatus{
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
    };

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