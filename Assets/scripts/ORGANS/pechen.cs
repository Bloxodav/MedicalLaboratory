using UnityEngine;

public class pechen : MonoBehaviour
{
    public GameObject objectToActivate; // Объект для активации

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pechen")) // Проверка на тег "heart"
        {
            objectToActivate.SetActive(true); // Активация объекта

            Destroy(other.gameObject); // Удаление объекта с тегом "heart"

        }
    }
}
