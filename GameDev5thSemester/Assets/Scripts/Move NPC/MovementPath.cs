using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPath : MonoBehaviour
{
    public enum PathTypes // виды пути: линейный или зацикленный
    {
        linear,
        loop
    }

    public PathTypes PathType; // определяет тип пути
    public int movementDirection = 1; // направление движения: вперед или назад
    public int moveingTo = 0; // к какой точке двигаться
    public Transform[] PathElements; // массив из точек движения

    public void OnDrawGizmos() // отображает линии между точками пути
    {
        if (PathElements == null || PathElements.Length < 2) //проверяет есть ли хотя бы 2 элемента пути
        {
            return;
        }

        for (var i = 1; i < PathElements.Length; i++) //прогоняет все точки массива 
        {
            Gizmos.DrawLine(PathElements[i - 1].position, PathElements[i].position); // рисует линии между ними
        }

        if (PathType == PathTypes.loop) // что призойдет если путь замкнется
        {
            Gizmos.DrawLine(PathElements[0].position, PathElements[PathElements.Length - 1].position); // нарисовать линию от последней тчоки к первой
        }
    }

    public IEnumerator<Transform> GetNextPathPoint() // получиет положение следующей точки
    {
        if (PathElements == null || PathElements.Length < 1) //проверяет, есть ли точки которым нужно проверять положение
        {
            yield break; // позволяет выйти из коротина если нашел несоответсвие
        }

        while (true)
        {
            yield return PathElements[moveingTo]; // возвращает текущее положение точки

            if (PathElements.Length == 1) // если тчока одна -> выйти
            {
                continue;
            }

            if (PathType == PathTypes.linear) // если линия не зациклена
            {
                if (moveingTo <= 0) // если двигаемся по нарастающей
                {
                    movementDirection = 1; // добавляем один к движению
                }
                else if (moveingTo >= PathElements.Length - 1) // если двигаемся по убывающей
                {
                    movementDirection = -1; // убираем один из движения
                }
            }

            moveingTo = moveingTo + movementDirection; // диапазон движения от 1 до -1


            if (PathType == PathTypes.loop) // если линия зациклена
            {
                if (moveingTo >= PathElements.Length) // если мы дошли до конца до последней точки
                {
                    moveingTo = 0; // то надо двгаться не в обратную тсорону, а к певрой точке
                }

                if (moveingTo < 0) // еслимы дошли до певрой точки двигаясь в обратную сторону
                {
                    moveingTo = PathElements.Length - 1; // то надо двинуть к последней точке
                }
            }
        }
    }


}
