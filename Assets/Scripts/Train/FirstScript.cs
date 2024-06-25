using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� �������� �������, ���������� ���������� VS � Unity
//����� ���� ��������� ��������� ���� ���������� � unity->edit->preference->external tools-> external script editor ������� MSVS

public class FirstScript : MonoBehaviour
{
    List<int> _list;//��������� ���������� ��� ��������� ������

    public void Awake()//������ �������� �� ���������� ������� �����
    {
        Debug.Log("Awake");
        _list = new List<int>();// �������������, ��������� ������(?)

    }

    // Start is called before the first frame update
    void Start()//������ �������� ����� ���������� ������� �����
    {
        Debug.Log("Start");
        _list.Add(12);
        _list.Add(100);
        _list.Add(11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //������������ ��� �������� ������
    private void FixedUpdate()//�� �����, ����� ���� �������� ������������ �� ������
    {
        
    }
    private void LateUpdate()//
    {
        
    }

    private void OnEnable()//����������� ��� ������������� ���������� � ����������
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()//����������� ��� ��������������� ���������� � ����������
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()//����������� ��� �������� �������
    {
        Debug.Log("Destroy");

        foreach (int element in _list)//������ � ������� ��� �������� �����(�������) list (��������)
        {
            Debug.Log($"{element}");
        }

        _list.Clear();
    }

    void WriteinConsole()//������� ������� ��� ����������
    {
        Debug.Log("Common message");
        Debug.LogWarning("Warning message");
        Debug.LogError("Error message");
    }
}
