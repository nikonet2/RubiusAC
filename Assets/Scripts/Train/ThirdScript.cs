using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class ThirdScript : MonoBehaviour
//{
//    public GameObject PrefabToInit;//���������� ������� ������ �������
//    private GameObject _initedPrefab;//�������������(�����������) ������� ����� ����������

//    private void Start()
//    {
//        _initedPrefab = Instantiate(PrefabToInit);//���������� ������� �� �����
//        //Instantiate(PrefabToInit,this.transform,true);//����� �������� �������� (����������) �������, ��������� ����� ������, �� ������� ����� ���� ���������. ���� true - ������, ���� false - ������

//    }

//    private void OnDestroy()
//    {
//        //Destroy(PrefabToInit);//������, ��� ��� PrefabToInit �������� ������� �� ������ ������ �������
//        Destroy(_initedPrefab);
//    }
//}

//���� �����, ������ �������
//���� �����, ����� ������ ���� �� ������ ������������ ������� � ����������� �����������
//public class ThirdScript : MonoBehaviour
//{
//    public GameObject PrefabToInit;//���������� ������� ������ �������
//    private ObjectToSpawn _initedPrefab;//������������� ���������� �� ����� ������� �������

//    private void Start()
//    {
//        _initedPrefab = PrefabToInit.GetComponent<ObjectToSpawn>();//�������� GetComponent(����� GameObject) � GameObject 
//        _initedPrefab.WriteInConsole();//��� ��� � ������� GameObject
//    }

//    private void OnDestroy()
//    {
//        Destroy(_initedPrefab);
//    }
//}

//����� ���� �� ����������
public class ThirdScript : MonoBehaviour
{
    public ObjectToSpawn Object;//�� �������� �������� ������ ��� ������������ ����������, � ������ ObjectToSpawn(������)

    private void Start()
    {
        Object.WriteInConsole();
    }

    private void OnDestroy()
    {

    }
}
