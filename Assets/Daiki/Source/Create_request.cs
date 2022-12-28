using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_request : MonoBehaviour
{
    public GameObject  request;
    public GameObject  request_botton;

    public void request_company(){
        for(int j=0;j<GManager.instance.company_amount;j++)
        {
            GManager.instance.company_reaction[j,0]=0;
            GManager.instance.company_reaction[j,1]=3;
            GManager.instance.company_reaction[j,2]=3;
            GManager.instance.company_reaction[j,3]=3;
        }
        for(int i=0;i<GManager.instance.company_amount;i++)
        {
            //相場を代入
            GManager.instance.company_reaction[i,0]=GManager.instance.req_market_price[GManager.instance.scale[GManager.instance.create_req]];
            if((GManager.instance.scale[GManager.instance.create_req]<=GManager.instance.company_status[i,0])||((GManager.instance.coBW[i])&&(GManager.instance.scale[GManager.instance.create_req]<=GManager.instance.company_status[i,0]+1))){
                GManager.instance.company_reaction[i,1]=3;
            }
            else{
                GManager.instance.company_reaction[i,1]=0;
                GManager.instance.company_reaction[i,0]+=(GManager.instance.req_market_price[GManager.instance.scale[GManager.instance.create_req]-1]/2);
            }
            if(GManager.instance.market_deadline[GManager.instance.scale[GManager.instance.create_req]]-1<=GManager.instance.deadline[GManager.instance.create_req]){
                if(GManager.instance.market_deadline[GManager.instance.scale[GManager.instance.create_req]]+1>=GManager.instance.deadline[GManager.instance.create_req]){
                    GManager.instance.company_reaction[i,0]=(GManager.instance.company_reaction[i,0]*9)/10;
                } 
                else    GManager.instance.company_reaction[i,2]=3;
            }
            else{
                GManager.instance.company_reaction[i,0]=(GManager.instance.company_reaction[i,0]*11)/10;
                GManager.instance.company_reaction[i,2]=1;
            }
            if(GManager.instance.company_reaction[i,0]<=GManager.instance.req_budget_upper[GManager.instance.create_req]){
                GManager.instance.company_reaction[i,0]=2;
                GManager.instance.company_reaction[i,3]=2;
            }
        }
            Debug.Log(0);
            Debug.Log(GManager.instance.company_reaction[0,0]);
            Debug.Log(GManager.instance.reaction[GManager.instance.company_reaction[0,1]]);
            Debug.Log(GManager.instance.reaction[GManager.instance.company_reaction[0,2]]);
            Debug.Log(1);
            Debug.Log(GManager.instance.company_reaction[1,0]);
            Debug.Log(GManager.instance.reaction[GManager.instance.company_reaction[1,1]]);
            Debug.Log(GManager.instance.reaction[GManager.instance.company_reaction[1,2]]);
            Debug.Log(2);
            Debug.Log(GManager.instance.company_reaction[2,0]);
            Debug.Log(GManager.instance.reaction[GManager.instance.company_reaction[2,1]]);
            Debug.Log(GManager.instance.reaction[GManager.instance.company_reaction[2,2]]);
            Debug.Log(3);
            Debug.Log(GManager.instance.company_reaction[3,0]);
            Debug.Log(GManager.instance.reaction[GManager.instance.company_reaction[3,1]]);
            Debug.Log(GManager.instance.reaction[GManager.instance.company_reaction[3,2]]);
        request_botton.SetActive(false);
       // request.SetActive(false);
    }
}
