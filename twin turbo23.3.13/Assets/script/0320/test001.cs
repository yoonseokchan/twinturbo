using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age;                 //������ int ���� �̸��� age
        age = 30;                //age �� 30�� �Է� (=)�� �Է�
        Debug.Log(age);          //console.log â�� age ���� �����ش�

        float height1 = 160.5f;   //�ε��Ҽ����� float ���� �̸��� height1 �̰� 160.5f �� �Է�
        float height2;           //float �� height2 ���� (�Է� ���� ���� ���� NULL)
        height2 = height1;       //height1�� �ִ� height2�� �Է�
        Debug.Log(height2);      //console.log â�� height2 �� ���� �����ش�

        string name;              //���ڿ� name  ����
        name = "sera";           //name�� sera �Է�
        Debug.Log(name);         //console.log â�� name �� ���� �����ش�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
