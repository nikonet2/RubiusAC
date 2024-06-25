using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //удаление другого объекта при удалении этого объекта
    public GameObject ObjectToDestroy;//позволяет в компоненте объекта сделать ссылку на другой объект

    //для примера, появится в компонентах:
    public float Float;
    public int Int;
    public string String;
    public Vector3 vector3;
    public List<GameObject> GameObjects;

    private void OnEnable()
    {
        ObjectToDestroy.transform.localScale = new Vector3(1, 1, 1);//наглядное представление вектора
        //Vector3 vector = new Vector3();
        //vector.x=1;
        //vector.y=1;
        //vector.z=1.0f; - записываем дробные значения а не целочисленные (так правильно для оптимизации)
    }
    private void OnDisable()
    {
        ObjectToDestroy.transform.localScale = new Vector3(3, 3, 3);
    }
    private void OnDestroy()
    {
        Destroy(ObjectToDestroy);//изначально есть класс от юнити Object, от него наследуется класс GameObject, а от него уже MonoBehaviour
    }
}
