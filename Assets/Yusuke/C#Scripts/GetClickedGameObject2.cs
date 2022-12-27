using UnityEngine;
 
public class GetClickedGameObject2 : MonoBehaviour {
 
    GameObject clickedGameObject2;
    
 
    void Update () {
 
        if (Input.GetMouseButtonDown(0)) {
 
            clickedGameObject2 = null;
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
 
            if (Physics.Raycast(ray, out hit)) {
                clickedGameObject2 = hit.collider.gameObject;
            }
            GameObject childObject = clickedGameObject2.transform.Find("build2").gameObject;
            GameObject childObject2 = childObject.transform.Find("sign").gameObject;
            childObject2.transform.position = new Vector3(childObject.transform.position.x, childObject.transform.position.y - 100, childObject.transform.position.z);
            Debug.Log(clickedGameObject2);
        }
        
    }
}