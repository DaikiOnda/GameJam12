using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProductBlackco : MonoBehaviour //Companyinfo����Co1�`Co�S�܂ł�bool�̒l�������Ă���
{
public int Days = 0;//4�ӏ����ׂĂ��u���b�N��ƂɂȂ�܂ł̓���
public int Duringproduct = 0;//�u���b�N��Ƃ������_���ő�����܂ł̓���
public int BlackCo =0;//�u���b�N��Ƃ̉�Ђ̐�����
public bool ResultTurnbool=false;//���ʂ̃^�[������������true
public bool AfterresultReset=false;//���ʂ̃^�[�����I�������ɁA�u���b�N��Ƃ̃J�E���g��������
public Companyinfo com;

void Update()
    {
        if(Days>=365)//365�����߂��āA�Ȃ���Black��Ƃ����邩�ǂ���
        {
            if(BlackCo >= 1)//�����u���b�N��Ƃ��P�ȏ�ł�����΁A���͈̔͂̉�Ђ͂��ׂ�Black�ɂȂ�
            {
            for(int i=0;i<4;i++)com.Co[i] = false;//����̂S�Ђ�Black��Ƃɂ���
            }
            
            Days = 0;//������߂�
        }



    if(Duringproduct>=30)
    {
        int rnd = Random.Range(1, 5);// �� 1�`4�͈̔͂Ń����_���Ȑ����l���Ԃ�
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
             }Duringproduct=0;
    }


        if(ResultTurnbool==true){//���ʃ^�[�����������ɁA�u���b�N��Ƃ̐����m�F
            for(int i=0;i<4;i++)
            {
                if(com.Co[i]==false)
                {
                    BlackCo++;
                }
            }
            ResultTurnbool=false;//���s���false
        }
        if(AfterresultReset==true)
        {
            BlackCo=0;
            AfterresultReset=false;//���s���false
        }
        
 }}