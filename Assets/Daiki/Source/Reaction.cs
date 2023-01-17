using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaction : MonoBehaviour
{
    public GameObject company;
    Companyinfo com;
    // Start is called before the first frame update
    void Start()
    {
        com = company.GetComponent<Companyinfo>();
    }

    public void change(){
        string company;
        int company_num;
        company=GManager.instance.company_name.Replace("企業","");
        company_num=int.Parse(company)-1;
        if(com.Co[company_num]==false)  com.Co[company_num]=true;
    }
}
