using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * �L�����̍��W��ύX����Controller
 */
public class MoveController : MonoBehaviour {
    [SerializeField]
    float SPEED = 100f;

    private Rigidbody rigidBody;
    private Vector3 inputAxis;
    public Vector3 movingVelocity;

    void Start() {
        // �I�u�W�F�N�g�ɐݒ肵�Ă���Rigidbody�̎Q�Ƃ��擾����
        this.rigidBody = GetComponent<Rigidbody>();
        

    }

    void Update() {
        // x,���̓��͒l�𓾂�
        // ���ꂼ��+��-�̒l�Ɠ��͂̊֘A�t����Input Manager�Őݒ肳��Ă���
        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");
        movingVelocity = inputAxis * SPEED;
    }

    private void FixedUpdate() {
        // ���x��������
        rigidBody.velocity = new Vector3(movingVelocity.x, movingVelocity.y, rigidBody.velocity.z);
    }
}