using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPerson : MonoBehaviour
{
    public GameObject PrefabPerson;
    public static GameObject SpawnedPerson;//public static дает возможность использовать переменную в другом скрипте
    public static int activated = 0;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SpawnedPerson = Instantiate(PrefabPerson);//спавн префаба
            activated = 1;
        }
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Destroy(SpawnedPerson);
        }
    }
}
