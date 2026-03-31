using UnityEngine;

public class musl : MonoBehaviour
{
    public GameObject objectToActivate; // Объект для активации

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("penis")) // Проверка на тег "heart"
        {
            objectToActivate.SetActive(true); // Активация объекта

            Destroy(other.gameObject); // Удаление объекта с тегом "heart"

        }
    }
}
