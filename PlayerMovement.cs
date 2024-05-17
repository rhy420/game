using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // CharacterController コンポーネントの参照
    public CharacterController controller;
    // 移動速度
    public float speed = 5f;
    // ジャンプの力
    public float jumpForce = 5f;
    // 重力の影響力
    public float gravity = -9.81f;
    // 現在の落下速度
    private float verticalVelocity = 0f;

    void Start()
    {
        // CharacterController コンポーネントを取得
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 水平方向の入力を取得
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 移動方向を計算
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // 移動方向をカメラの向きに合わせる
        moveDirection = transform.TransformDirection(moveDirection);

        // 移動方向に速度を掛ける
        controller.Move(moveDirection * speed * Time.deltaTime);

        // ジャンプ処理
        if (controller.isGrounded && Input.GetKey(KeyCode.Space))
        {
            // ジャンプの力を与える
            verticalVelocity = jumpForce;
        }

        // 重力の影響を受ける
        verticalVelocity += gravity * Time.deltaTime;

        // 落下速度を適用
        controller.Move(Vector3.up * verticalVelocity * Time.deltaTime);
    }
}
//change to method 