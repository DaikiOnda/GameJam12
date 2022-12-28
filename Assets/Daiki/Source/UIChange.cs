using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChange : MonoBehaviour
{
    public GameObject  request;
    public GameObject  enhancement;
    public GameObject alarm;
    public void RequestUI()
    {
        request.SetActive(true);
    }
    public void EnhancementUI()
    {
        enhancement.SetActive(true);
    }
    public void alarmUIclose(){
        alarm.SetActive(false);
    }
    public void requestUIclose(){
        request.SetActive(false);
    }
}
