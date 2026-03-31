using UnityEngine;

public class man : MonoBehaviour
{
    public GameObject objectToActivate; // Объект для активации

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("man")) // Проверка на тег "heart"
        {
            objectToActivate.SetActive(true); // Активация объекта

            Destroy(other.gameObject); // Удаление объекта с тегом "heart"

        }
    }
}
