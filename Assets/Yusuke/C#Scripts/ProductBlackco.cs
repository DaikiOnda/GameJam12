using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProductBlackco : MonoBehaviour //Companyinfo����Co1�`Co�S�܂ł�bool�̒l�������Ă���
{
[SerializeField] int Days = 365;//4�ӏ����ׂĂ��u���b�N��ƂɂȂ�܂ł̓���
[SerializeField] int Duringproduct = 30;//�u���b�N��Ƃ������_���ő�����܂ł̓���
[SerializeField] int BlackCo =1;//�u���b�N��Ƃ̉�Ђ̐�����
public GameObject sp;
Companyinfo com;

    // Update is called once per frame
    void Start()
    {
    com = sp.GetComponent<Companyinfo>(); 
    }
    void Update()
    {
        if(Days>=360)//30�����߂��āA�Ȃ���Black��Ƃ����邩�ǂ���
        {
            if(BlackCo >= 1)//�����u���b�N��Ƃ��P�ȏ�ł�����΁A���͈̔͂̉�Ђ͂��ׂ�Black�ɂȂ�
            {
            for(int i=0;i<4;i++)com.Co[i] = false;//����̂S�Ђ�Black��Ƃɂ���
            }
            
            Days = 0;//������߂�
        }
        if(Duringproduct>=30)
        {
        int rnd = Random.Range(1, 5);�@// �� 1�`4�͈̔͂Ń����_���Ȑ����l���Ԃ�
        switch(rnd) {
        case 1:
            com.Co[0]=false;
            break;
        case 2:
            com.Co[1]=false;
            break;
        case 3:
            com.Co[2]=false;
            break;
        case 4:
            com.Co[3]=false;
            break;
}             }Duringproduct=0;
        }
    
    }
