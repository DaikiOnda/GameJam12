using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resultnews : MonoBehaviour
{
    public ResultTextbudget rb;
    [SerializeField] GameObject Gameover;
    [SerializeField] GameObject GameClear;
    // Start is called before the first frame update
    void Start()
    {
        if(rb.budgetrs >= 52000)
        {
            GameClear.SetActive(true);
        }else{
            Gameover.SetActive(true);
        }
    }

    
}
