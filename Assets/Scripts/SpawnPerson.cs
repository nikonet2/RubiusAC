using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPerson : MonoBehaviour
{
    public GameObject PrefabPerson;
    public static GameObject SpawnedPerson;//public static ���� ����������� ������������ ���������� � ������ �������
    public static int activated = 0;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SpawnedPerson = Instantiate(PrefabPerson);//����� �������
            activated = 1;
        }
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Destroy(SpawnedPerson);
        }
    }
}
