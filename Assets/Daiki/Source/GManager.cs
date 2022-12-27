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
    public bool[] black={};
    public struct CompanyStatus{
        public int cId;
        public bool black;
        public int Mlimit;
        public int Tlimit;
        public int Dlimit;
        public int Mcorrection;
        public int Tcorrection;
        public int Dcorrection;
    
        public CompanyStatus(int p1, bool p2,int p3,int p4,int p5,int p6,int p7,int p8)
        {
            this.cId = p1;
            this.black = p2;
            this.Mlimit = p3;
            this.Tlimit = p4;
            this.Dlimit = p5;
            this.Mcorrection = p6;
            this.Tcorrection = p7;
            this.Dcorrection = p8;
        }
    }
    private CompanyStatus[] coList = {
            new CompanyStatus(0,false,10,1,3,-10,1,2),
            new CompanyStatus(1,false,10,1,3,-10,1,2),
            new CompanyStatus(2,false,10,1,3,-10,1,2),
            new CompanyStatus(3,false,10,1,3,-10,1,2),
            new CompanyStatus(4,false,10,1,3,-10,1,2),
            new CompanyStatus(5,false,10,1,3,-10,1,2),
            new CompanyStatus(6,false,10,1,3,-10,1,2),
            new CompanyStatus(7,false,10,1,3,-10,1,2),
            new CompanyStatus(-1,false,0,0,0,0,0,0)    // -1は、終端の意味として使う
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