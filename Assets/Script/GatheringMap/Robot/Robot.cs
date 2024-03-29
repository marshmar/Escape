using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    private float moveSpeed = 6.0f;
    private float hp = 100.0f;

    private List<int> ArmIdx = new List<int>();

    //Rigidbody2D rigid;

    void Start()
    {
        //rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveDirection = Vector3.zero;

        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            moveDirection = Vector3.left; // Vector3(-1, 0 , 0);
        }

        else if(Input.GetAxisRaw("Horizontal") > 0)
        {
            moveDirection = Vector3.right; //Vector3(1, 0 , 0);
        }

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
