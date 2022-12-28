using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOpen : MonoBehaviour
{
    public GameObject  request;
    public GameObject  enhancement;
    public void RequestUI()
    {
        request.SetActive(true);
    }
    public void EnhancementUI()
    {
        enhancement.SetActive(true);
    }
}
