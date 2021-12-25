using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterControler : MonoBehaviour
{
    //��� ���� ������� ���������� ��������, �������� , �������� ��������, ��������� ��������
    public float move, rotate;
    private Rigidbody rb;
    public float moveSpeed, rotateSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // ��� ��� ��������� � ������� ������
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
        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);//���������� ����� ���� ������ ��� Y
        rb.MoveRotation(rb.rotation * turnRotation);//�� �������� � �������� 


    }
    // ��� �� ��������� ������� ��� �������� � ��������
    private void Update()
    {
        move = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
        
    }

}
