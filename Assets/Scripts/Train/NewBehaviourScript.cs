using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //�������� ������� ������� ��� �������� ����� �������
    public GameObject ObjectToDestroy;//��������� � ���������� ������� ������� ������ �� ������ ������

    //��� �������, �������� � �����������:
    public float Float;
    public int Int;
    public string String;
    public Vector3 vector3;
    public List<GameObject> GameObjects;

    private void OnEnable()
    {
        ObjectToDestroy.transform.localScale = new Vector3(1, 1, 1);//��������� ������������� �������
        //Vector3 vector = new Vector3();
        //vector.x=1;
        //vector.y=1;
        //vector.z=1.0f; - ���������� ������� �������� � �� ������������� (��� ��������� ��� �����������)
    }
    private void OnDisable()
    {
        ObjectToDestroy.transform.localScale = new Vector3(3, 3, 3);
    }
    private void OnDestroy()
    {
        Destroy(ObjectToDestroy);//���������� ���� ����� �� ����� Object, �� ���� ����������� ����� GameObject, � �� ���� ��� MonoBehaviour
    }
}
