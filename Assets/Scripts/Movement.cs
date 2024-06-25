using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*�������� ��������� �� ����� ������� � ��������
 1. ���� �������� ���� ������ �� ������, �� �� ��������� ������ ����� �������, ��� ��� �� ����� ������ ���
 2. ���� �� ����� ��� �������, �� ������� ������ ������, �� ������ ������*/
public class Movement : MonoBehaviour
{
    //public GameObject PrefabToInit;//���������� ������� ������ �������
    //private GameObject _initedPrefab;//�������������(�����������) ������� ����� ����������
    public int activate = 0;

    public Transform CubeTransform;
    public float Speed;
    public float SpeedRotate;

    public KeyCode Forward;
    public KeyCode Backward;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode RotatePlus;
    public KeyCode RotateMinus;

    private void Start()
    {
        if (CubeTransform == null)//�������������� ���� ������ �� ���������
        {
            CubeTransform = transform;
        }

        Forward = KeyCode.W;
        Backward = KeyCode.S;
        Left = KeyCode.A;
        Right=KeyCode.D;
        RotatePlus = KeyCode.E;
        RotateMinus = KeyCode.Q;

        //����� �� ����� ���������������� ��������� �������� ��� � Awake?
        Speed = 0.02f;
        SpeedRotate = 0.5f;

        //_initedPrefab = Instantiate(PrefabToInit);//���������� ������� �� �����
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))//���������������� � ��������� �������
        {
            activate = 1;
        }
        if (activate == 1)
        {
            if (Input.GetKey(Forward))
            {
                CubeTransform.Translate(Vector3.forward * Speed);//��� �������� �� �������
            }
            if (Input.GetKey(Backward))
            {
                CubeTransform.Translate(Vector3.back * Speed);
            }
            if (Input.GetKey(Right))
            {
                CubeTransform.Translate(Vector3.right * Speed);
            }
            if (Input.GetKey(Left))
            {
                CubeTransform.Translate(Vector3.left * Speed);
            }
            if (Input.GetKey(RotatePlus))
            {
                CubeTransform.Rotate(Vector3.up * SpeedRotate);//�������� �� vector2?
                                                               //CubeTransform.Rotate(Vector3(0,1,0)); �� ��������
            }
            if (Input.GetKey(RotateMinus))
            {
                CubeTransform.Rotate(Vector2.down * SpeedRotate);//����� �������� -__-
            }
        }
        
    }
}
