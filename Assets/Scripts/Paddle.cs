using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Paddle : MonoBehaviour
{
    Rigidbody2D PaddleRigidbody;

    [SerializeField]
    float Speed = 5f;
    [SerializeField]
    float MaxPosition = 7.25f;

    void Start()
    {
        PaddleRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var TargetSpeed = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
            TargetSpeed = Vector2.left;

        else if(Input.GetKey(KeyCode.D))
            TargetSpeed = Vector2.right;

        PaddleRigidbody.velocity = TargetSpeed * Speed;

        
        var positionX = Mathf.Clamp(transform.position.x, -MaxPosition, MaxPosition);
        transform.position = new Vector2(positionX, transform.position.y);
        
    }
}
