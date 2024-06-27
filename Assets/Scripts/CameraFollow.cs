using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    /*Добавить ориентированность камеры по одной из осей относительно цели*/
    public Transform _target; //указатель на цель слежения
    //можно ли использовать private вместо public
    public Vector3 _offcet; //радиус-вектор до цели
    public float _smoothing;//скорость перемещения

    public Camera _cameraFollow;//ссылка на объект Camera
    public Camera _cameraStatic;

    private void Start()
    {
        _smoothing = 3f;//скорость перемещения

        _cameraFollow = Camera.main;//"кто тут главный?"
        _cameraFollow=GetComponent<Camera> ();//обращение к компоненту Camera у объекта типа Camera (чтобы знать, что переключать)
    }
    void Update()
    {
        //Прявязка камеры с появившемуся объекту (персонажу) после запуска !!!че по оптимизации - оно же постоянно проверяется?!!!
        if (_target == null& SpawnPerson.activated == 1)
        {
            _target = SpawnPerson.SpawnedPerson.transform;
        }
        //Переключение между камерами нажатием V
        if (Input.GetKeyDown(KeyCode.V))
        {
            _cameraFollow.enabled = !_cameraFollow.enabled;
            _cameraStatic.enabled = !_cameraStatic.enabled;
        }

        Move(); 
    }

    private void Move()
    {
        var nextPosition = Vector3.Lerp(transform.position,_target.position+_offcet,Time.deltaTime*_smoothing);//что такое var и Time.deltatime?
        //Lerp - интерполяция между точками положения камеры и цели
        transform.position = nextPosition;
    }
}
