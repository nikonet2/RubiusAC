using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    /*�������� ����������������� ������ �� ����� �� ���� ������������ ����*/
    public Transform _target; //��������� �� ���� ��������
    //����� �� ������������ private ������ public
    public Vector3 _offcet; //������-������ �� ����
    public float _smoothing;//�������� �����������

    public Camera _cameraFollow;//������ �� ������ Camera
    public Camera _cameraStatic;

    private void Start()
    {
        _smoothing = 3f;//�������� �����������

        _cameraFollow = Camera.main;//"��� ��� �������?"
        _cameraFollow=GetComponent<Camera> ();//��������� � ���������� Camera � ������� ���� Camera (����� �����, ��� �����������)
    }
    void Update()
    {
        //�������� ������ � ������������ ������� (���������) ����� ������� !!!�� �� ����������� - ��� �� ��������� �����������?!!!
        if (_target == null& SpawnPerson.activated == 1)
        {
            _target = SpawnPerson.SpawnedPerson.transform;
        }
        //������������ ����� �������� �������� V
        if (Input.GetKeyDown(KeyCode.V))
        {
            _cameraFollow.enabled = !_cameraFollow.enabled;
            _cameraStatic.enabled = !_cameraStatic.enabled;
        }

        Move(); 
    }

    private void Move()
    {
        var nextPosition = Vector3.Lerp(transform.position,_target.position+_offcet,Time.deltaTime*_smoothing);//��� ����� var � Time.deltatime?
        //Lerp - ������������ ����� ������� ��������� ������ � ����
        transform.position = nextPosition;
    }
}
