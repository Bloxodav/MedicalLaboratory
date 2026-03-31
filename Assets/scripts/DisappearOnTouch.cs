using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnTouch : MonoBehaviour
{
    // Счетчик количества касаний
    private int touchCount = 0;

    // Метод, который вызывается при столкновении с другим коллайдером
    private void OnCollisionEnter(Collision collision)
    {
        // Проверяем, имеет ли другой объект тег "pencil"
        if (collision.gameObject.CompareTag("pencil"))
        {
            // Увеличиваем счетчик на 1
            touchCount++;

            // Если счетчик равен 2, то уничтожаем этот объект
            if (touchCount == 2)
            {
                Destroy(gameObject);
            }
        }
    }
}
