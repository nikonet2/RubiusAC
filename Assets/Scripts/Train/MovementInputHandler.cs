using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInputHandler : MonoBehaviour
{
    public Transform CubeTransform;

    private void Start()
    {
        if(CubeTransform == null)//автоматический ввод ссылки на трансформ
        {
            CubeTransform = transform;
        }
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            CubeTransform.Translate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            CubeTransform.Translate(Vector3.back);
        }
    }
}
