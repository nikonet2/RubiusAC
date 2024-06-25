using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Добавить появление на сцене префаба и удаление
 1. Если добавить этот скрипт на перфаб, то не появиться объект после нажатия, так как на сцене ничего нет
 2. Если на сцене нет объекта, за которым следит камера, то выдает ошибку*/
public class Movement : MonoBehaviour
{
    //public GameObject PrefabToInit;//объявление префаба внутри проекта
    //private GameObject _initedPrefab;//инициализация(кеширование) префаба через переменную
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

        //нужно ли здесь инициализировать начальные значения или в Awake?
        Speed = 0.02f;
        SpeedRotate = 0.5f;

        //_initedPrefab = Instantiate(PrefabToInit);//размещение префаба на сцене
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))//трансформировать в появление объекта
        {
            activate = 1;
        }
        if (activate == 1)
        {
            if (Input.GetKey(Forward))
            {
                CubeTransform.Translate(Vector3.forward * Speed);//нет привязки ко времени
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
}
