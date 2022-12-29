using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Searchreply : MonoBehaviour
{
public Companyinfo com;
GameObject clickedGameObject;
public GameObject panel;//Button�̔�\��,�\���̋敪��
public GameObject reaction;
public Text text;
public bool Searchbool=false;//if this bool is true,you can get Update method
public bool Waittime = false;//Button�������܂�Update�̒��g�̋������~�߂�
    // Update is called once per frame
   
void Update()
{
    if(Searchbool==true)//When turn is Searchturn,this content will be conducted
    {
        if(Waittime == false)
        {
           if (Input.GetMouseButtonDown(0)) 
           {//�I�u�W�F�N�g���N���b�N���ꂽ�Ƃ����̒������s�����
 
                clickedGameObject = null;
 
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();
 
                if (Physics.Raycast(ray, out hit)) 
                {
                    clickedGameObject = hit.collider.gameObject;//�N���b�N���ꂽ�I�u�W�F�N�g����
                }
           
               panel.SetActive(true);//Button�̕\��
               Debug.Log(clickedGameObject);
               Waittime=true;
                
            }
        }
            if(Input.GetKey(KeyCode.Escape))
            {   //esc�L�[�������ꂽ�Ƃ��ɁAPanel��ʂ����ɖ߂�
                panel.SetActive(false);//Button�̔�\��
                reaction.SetActive(false);
                Waittime=false;
            }
    }
}
    
    public void OnClickSearch()//����Button�������ꂽ�Ƃ�
    {
         //�N���b�N���ꂽ�I�u�W�F�N�g�̊Ŕ��グ��
          GameObject childObject = clickedGameObject.transform.Find("sign").gameObject;
          switch(clickedGameObject.name)
          {//�N���b�N���ꂽ�����̖��O���ǂ�ɓ����邩�̑I��
            case "企業1":
                if(com.Co[0]==false){//�������̉�Ђ��u���b�N��������Ŕ��o��
                    childObject.SetActive(true);
                    //text.text="���̉�Ђ̓u���b�N��Ƃ�����";
                }
                break;
            case "企業2":
                if(com.Co[1]==false){
                    childObject.SetActive(true);
                    //text.text="���̉�Ђ̓u���b�N��Ƃ�����";
                }
                break;
            case "企業3":
                if(com.Co[2]==false){
                    childObject.SetActive(true);
                    //text.text="���̉�Ђ̓u���b�N��Ƃ�����";
                }
                break;
            case "企業4":
                if(com.Co[3]==false){
                    childObject.SetActive(true);
                    //text.text="���̉�Ђ̓u���b�N��Ƃ�����";
                }
            break;
          }
            
           panel.SetActive(false);//Button will be invisible
           Waittime=false;
    }
    
}
