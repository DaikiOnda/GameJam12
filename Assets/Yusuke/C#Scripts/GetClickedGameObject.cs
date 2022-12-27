using UnityEngine;
 
public class GetClickedGameObject : Companyinfo {
 
    GameObject clickedGameObject;
    void Update () {
 
        if (Input.GetMouseButtonDown(0)) {//�I�u�W�F�N�g���N���b�N���ꂽ�Ƃ����̒������s�����
 
            clickedGameObject = null;
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
 
            if (Physics.Raycast(ray, out hit)) {
                clickedGameObject = hit.collider.gameObject;//�N���b�N���ꂽ�I�u�W�F�N�g����
            }

            //�N���b�N���ꂽ�I�u�W�F�N�g�̊Ŕ�������
            GameObject childObject = clickedGameObject.transform.Find("build1").gameObject;
            GameObject childObject2 = childObject.transform.Find("sign").gameObject;
            childObject2.transform.position = new Vector3(childObject.transform.position.x, childObject.transform.position.y - 100, childObject.transform.position.z);
           

            Debug.Log(clickedGameObject);
        }
        
    }
}