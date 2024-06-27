using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public GameObject PrefabToInit;//объ€вление префаба внутри проекта
    //private GameObject _initedPrefab;//инициализаци€(кеширование) префаба через переменную
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
        if (CubeTransform == null)//автоматический ввод ссылки на трансформ
        {
            CubeTransform = transform;
        }

        Forward = KeyCode.W;
        Backward = KeyCode.S;
        Left = KeyCode.A;
        Right=KeyCode.D;
        RotatePlus = KeyCode.E;
        RotateMinus = KeyCode.Q;

        //нужно ли здесь инициализировать начальные значени€ или в Awake?
        Speed = 0.02f;
        SpeedRotate = 0.5f;
    }
    void Update()
    {
        if (Input.GetKey(Forward))
        {
            CubeTransform.Translate(Vector3.forward * Speed);//нет прив€зки ко времени
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
            CubeTransform.Rotate(Vector3.up * SpeedRotate);//подходит ли vector2?
                                                           //CubeTransform.Rotate(Vector3(0,1,0)); не работает
        }
        if (Input.GetKey(RotateMinus))
        {
            CubeTransform.Rotate(Vector2.down * SpeedRotate);//вроде работает -__-
        }
    }
}
