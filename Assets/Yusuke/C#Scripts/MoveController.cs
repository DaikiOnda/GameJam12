using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * キャラの座標を変更するController
 */
public class MoveController : MonoBehaviour {
    [SerializeField]
    float SPEED = 100f;

    private Rigidbody rigidBody;
    private Vector3 inputAxis;
    public Vector3 movingVelocity;

    void Start() {
        // オブジェクトに設定しているRigidbodyの参照を取得する
        this.rigidBody = GetComponent<Rigidbody>();
        

    }

    void Update() {
        // x,ｙの入力値を得る
        // それぞれ+や-の値と入力の関連付けはInput Managerで設定されている
        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");
        movingVelocity = inputAxis * SPEED;
    }

    private void FixedUpdate() {
        // 速度を代入する
        rigidBody.velocity = new Vector3(movingVelocity.x, movingVelocity.y, rigidBody.velocity.z);
    }
}