using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductBlackco : Companyinfo //Companyinfo����Co1�`Co�S�܂ł�bool�̒l�������Ă���
{
[SerializeField] int Days = 365;//4�ӏ����ׂĂ��u���b�N��ƂɂȂ�܂ł̓���
[SerializeField] int Duringproduct = 30;//�u���b�N��Ƃ������_���ő�����܂ł̓���
[SerializeField] int BlackCo =1;//�u���b�N��Ƃ̉�Ђ̐�����

    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()
    {
        if(Days>=360)//30�����߂��āA�Ȃ���Black��Ƃ����邩�ǂ���
        {
            if(BlackCo >= 1)//�����u���b�N��Ƃ��P�ȏ�ł�����΁A���͈̔͂̉�Ђ͂��ׂ�Black�ɂȂ�
            {
            Co1=false;//����̂S�Ђ�Black��Ƃɂ���
            Co2=false;//����̂S�Ђ�Black��Ƃɂ���
            Co3=false;//����̂S�Ђ�Black��Ƃɂ���
            Co4=false;//����̂S�Ђ�Black��Ƃɂ���
            }
            
            Days = 0;//������߂�
        }
        if(Duringproduct>=30)
        {
        int rnd = Random.Range(1, 5);�@// �� 1�`4�͈̔͂Ń����_���Ȑ����l���Ԃ�
        switch(rnd) {
        case 1:
            Co1=false;
            break;
        case 2:
            Co2=false;
            break;
        case 3:
            Co3=false;
            break;
        case 4:
            Co4=false;
            break;
}

         Duringproduct=0;
        }
    }
    
}
