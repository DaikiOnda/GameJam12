using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GladorSad : MonoBehaviour
{
private Animator animator;
public ResultTextbudget rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    if(rb.budgetrs>630000)
    {   
        animator.SetBool("result",true);
    }else{
        animator.SetBool("result",false);
    }
        
    }
}
