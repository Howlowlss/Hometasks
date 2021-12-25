using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterControler : MonoBehaviour
{
    //нам надо создать переменные движения, поворота , скорости движения, скоровсти поворота
    public float move, rotate;
    private Rigidbody rb;
    public float moveSpeed, rotateSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // так как двигаемся с помощью физики
    private void FixedUpdate()
    {

        Move();
        Rotate();
    }

    private void Move()
    {
        Vector3 movement = transform.forward * move * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

    }
    private void Rotate()
    {
        float turn = rotate * rotateSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);//превращает любые углы вокруг оси Y
        rb.MoveRotation(rb.rotation * turnRotation);//по аналогии с позицией 


    }
    // что бы назначить клавишы для движения и поворота
    private void Update()
    {
        move = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
        
    }

}
