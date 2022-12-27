using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOpen : MonoBehaviour
{
    public GameObject  request;
    public GameObject  enhancement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RequestUI()
    {
        request.SetActive(true);
    }
    public void EnhancementUI()
    {
        enhancement.SetActive(true);
    }
}
