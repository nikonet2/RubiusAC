using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//чтобы включить отладку, необходимо подключить VS к Unity
//чтобы была подсветка командных слов необходимо в unity->edit->preference->external tools-> external script editor выбрать MSVS

public class FirstScript : MonoBehaviour
{
    List<int> _list;//обявление переменной без выделения памяти

    public void Awake()//логика строится до построения первого кадра
    {
        Debug.Log("Awake");
        _list = new List<int>();// инициализация, выделение памяти(?)

    }

    // Start is called before the first frame update
    void Start()//логика строится после построения первого кадра
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
    //Используется для просчета физики
    private void FixedUpdate()//не знаем, когда кадр закончит отображаться на экране
    {
        
    }
    private void LateUpdate()//
    {
        
    }

    private void OnEnable()//выполняется при активировании компонента в инспекторе
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()//выполняется при деактивировании компонента в инспекторе
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()//выполняется при удалении объекта
    {
        Debug.Log("Destroy");

        foreach (int element in _list)//выдаст в консоль все элементы листа(массива) list (неудобно)
        {
            Debug.Log($"{element}");
        }

        _list.Clear();
    }

    void WriteinConsole()//обычная функция без параметров
    {
        Debug.Log("Common message");
        Debug.LogWarning("Warning message");
        Debug.LogError("Error message");
    }
}
