using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequestSet : MonoBehaviour
{
    [SerializeField] Dropdown dropdown;
    //private sring a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Call(int scale)
    {     
        GManager.instance.scale[GManager.instance.create_req]=scale;
        if(scale==0){
            dropdown.options[0].text = "半月";
            dropdown.options[1].text = (1+scale*2)+"か月";
            dropdown.options[2].text = (1+scale*2)+"か月半";
            dropdown.options[3].text = (2+scale*2)+"か月";
            dropdown.options[4].text = (2+scale*2)+"か月半";
            dropdown.options[5].text = (3+scale*2)+"か月";
            dropdown.options[6].text = (3+scale*2)+"か月半";
        }
        else if(scale>0){
            dropdown.options[0].text =(scale*2-1)+ "か月半";
            dropdown.options[1].text = (scale*2)+"か月";
            dropdown.options[2].text = (scale*2)+"か月半";
            dropdown.options[3].text = (1+scale*2)+"か月";
            dropdown.options[4].text = (1+scale*2)+"か月半";
            dropdown.options[5].text = (2+scale*2)+"か月";
            dropdown.options[6].text = (2+scale*2)+"か月半";
            
        }
        switch (dropdown.value)
        {
            case 0:
                if(scale==0){
                    dropdown.captionText.text = "半月";
                }
                else if(scale>0){
                    dropdown.captionText.text = (scale*2-1)+ "か月半";
                }
                break;
            case 1:
                if(scale==0){
                    dropdown.captionText.text =(1+scale*2)+"か月";
                }
                else if(scale>0){
                    dropdown.captionText.text = (scale*2)+ "か月半";
                }
                break;
            case 2:
                if(scale==0){
                    dropdown.captionText.text = (1+scale*2)+"か月半";
                }
                else if(scale>0){
                    dropdown.captionText.text = (scale*2)+ "か月半";
                }
                break;
            case 3:
                if(scale==0){
                    dropdown.captionText.text =(2+scale*2)+"か月";
                }
                else if(scale>0){
                    dropdown.captionText.text = (1+scale*2)+ "か月";
                }
                break;
            case 4:
                if(scale==0){
                    dropdown.captionText.text = (2+scale*2)+"か月半";
                }
                else if(scale>0){
                    dropdown.captionText.text = (1+scale*2)+ "か月半";
                }
                break;
            case 5:
                if(scale==0){
                    dropdown.captionText.text = (3+scale*2)+"か月";
                }
                else if(scale>0){
                    dropdown.captionText.text = (2+scale*2)+ "か月";
                }
                break;
            case 6:
                if(scale==0){
                    dropdown.captionText.text = (3+scale*2)+"か月半";
                }
                else if(scale>0){
                    dropdown.captionText.text = (2+scale*2)+ "か月半";
                }
                break;
        }
    }
    public void CallT(int time){
        if(GManager.instance.scale[GManager.instance.create_req]==0)    GManager.instance.deadline[GManager.instance.create_req]=1+time;
        else    GManager.instance.deadline[GManager.instance.create_req]=GManager.instance.scale[GManager.instance.create_req]*4+time; 
    }
}
