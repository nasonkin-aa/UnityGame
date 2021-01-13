using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public enum MovementType
    {
        Movieng,
        Lerping
    }

    public MovementType Type = MovementType.Movieng; // вид движения
    public MovementPath MyPath; // используемый путь
    public float speed = 1; // скорость движения
    public float maxDistance = .1f; // на какое расстояние должен подъехать обьект к точке, чтобы понять что это точка

    private IEnumerator<Transform> pointInPath; // проверка точек


    // Start is called before the first frame update
    void Start()
    {
        if (MyPath == null) // проверка прикреплен ли путь
        {
            Debug.Log("Примени путь"); // сообщение консоли о проверке
            return;
        }

        pointInPath = MyPath.GetNextPathPoint(); // обращение к коротину GetNextPathPoint

        pointInPath.MoveNext(); // получение следующей точки в пути 

        if (pointInPath.Current == null) // есть ли точка к которой передвигаться
        {
            Debug.Log("Нужны точки"); // иначе сообщение
            return;
        }

        transform.position = pointInPath.Current.position; // объект должен стать на стартовую точку пути
    }

    // Update is called once per frame
    void Update()
    {
        if (pointInPath == null || pointInPath.Current == null) // проверка отсутствия пути
        {
            return; // выход, потому что пути нет
        }

        if (Type == MovementType.Movieng) // если выбран этот вид
        {
            transform.position = Vector3.MoveTowards(transform.position, pointInPath.Current.position, Time.deltaTime * speed);// двигать объект к следующей точке
        }

        else if (Type == MovementType.Lerping) // если выбран этот вид
        {
            transform.position = Vector3.Lerp(transform.position, pointInPath.Current.position, Time.deltaTime * speed); // двигать к следующей тчоке
        }


        var distanceSqure = (transform.position - pointInPath.Current.position).sqrMagnitude;
        if (distanceSqure < maxDistance * maxDistance) // достаточно ли мы близко по теореме пифагора
        {
            pointInPath.MoveNext(); // двигаем к следующец точке
        }
    }
}
