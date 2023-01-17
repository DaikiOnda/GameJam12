using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    void OnMouseEnter()
    {
        Panel.SetActive(true);
    }
    void OnMouseExit()
    {
        Panel.SetActive(false);
    }
}
