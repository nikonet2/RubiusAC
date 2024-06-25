using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class ThirdScript : MonoBehaviour
//{
//    public GameObject PrefabToInit;//объ€вление префаба внутри проекта
//    private GameObject _initedPrefab;//инициализаци€(кеширование) префаба через переменную

//    private void Start()
//    {
//        _initedPrefab = Instantiate(PrefabToInit);//размещение префаба на сцене
//        //Instantiate(PrefabToInit,this.transform,true);//можем записать родител€ (экземпл€ру) префабу, родителем будет объект, на котором висит этот компонент. ≈сли true - √лоб— , если false - —в€з— 

//    }

//    private void OnDestroy()
//    {
//        //Destroy(PrefabToInit);//ошибка, так как PrefabToInit €вл€етс€ ссылкой на объект внутри проекта
//        Destroy(_initedPrefab);
//    }
//}

//тоже самое, только сложнее
//если нужно, чтобы ссылка была на префаб конкректного объекта с конкректным компонентом
//public class ThirdScript : MonoBehaviour
//{
//    public GameObject PrefabToInit;//объ€вление префаба внутри проекта
//    private ObjectToSpawn _initedPrefab;//инициализаци€ переменной из имени другого скрипта

//    private void Start()
//    {
//        _initedPrefab = PrefabToInit.GetComponent<ObjectToSpawn>();//вызывает GetComponent(метод GameObject) у GameObject 
//        _initedPrefab.WriteInConsole();//так как у объекта GameObject
//    }

//    private void OnDestroy()
//    {
//        Destroy(_initedPrefab);
//    }
//}

//метод выше не эффективен
public class ThirdScript : MonoBehaviour
{
    public ObjectToSpawn Object;//не позволит положить объект без необходимого компонента, а именно ObjectToSpawn(скрипт)

    private void Start()
    {
        Object.WriteInConsole();
    }

    private void OnDestroy()
    {

    }
}
