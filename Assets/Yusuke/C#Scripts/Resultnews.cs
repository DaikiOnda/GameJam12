using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resultnews : MonoBehaviour
{
    [SerializeField] GameObject Gameover;
    [SerializeField] GameObject GameClear;
    // Start is called before the first frame update
    void Start()
    {
        if(GManager.instance.budget >= 52000)
        {
            GameClear.SetActive(true);
        }else{
            Gameover.SetActive(true);
        }
    }

    
}
