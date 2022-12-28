using UnityEngine;
using UnityEngine.UI;
public class GetClickedGameObject : MonoBehaviour {
 
    GameObject clickedGameObject;
    public GameObject panel;
    public GameObject reaction;
    bool Waittime = false;//Button�������܂�Update�̒��g�̋������~�߂�
    public Text text;
    void Update () {
        if(Waittime == false){
 
        if (Input.GetMouseButtonDown(0)) {//�I�u�W�F�N�g���N���b�N���ꂽ�Ƃ����̒������s�����
 
            clickedGameObject = null;
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
 
            if (Physics.Raycast(ray, out hit)) {
                clickedGameObject = hit.collider.gameObject;//�N���b�N���ꂽ�I�u�W�F�N�g����
            }
            panel.SetActive(true);
            Debug.Log(clickedGameObject);
            Waittime = true;
        }
        
        }
        if(Input.GetKey(KeyCode.Escape)){//esc�L�[�������ꂽ�Ƃ��ɁAPanel��ʂ����ɖ߂�
             panel.SetActive(false);
             reaction.SetActive(false);
            Waittime=false;
        }
        
    }
      public void OnClick()
    {
         //�N���b�N���ꂽ�I�u�W�F�N�g�̊Ŕ�������
            GameObject childObject = clickedGameObject.transform.Find("sign").gameObject;
            childObject.SetActive(false);
            panel.SetActive(false);
            reaction.SetActive(true);
            text.text="���̉�Ђ͎c�Ƒ��\n   �����Ă��Ȃ�����";
            Waittime=false;
    }
}