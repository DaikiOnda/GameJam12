using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultTextbudget : MonoBehaviour
{
    [SerializeField] Text money;
    public int budgetrs = 12234;//you can change this variable
    int oku=0;
    int man=0;
    // Start is called before the first frame update
    void Start()
    {
    
    oku=budgetrs/10000;
    man=budgetrs%10000;

     if(oku>0)   money.text = "—\ŽZ "+oku+"‰­"+man+"–œ";
        else   money.text = "—\ŽZ "+man+"–œ";
    }
}
