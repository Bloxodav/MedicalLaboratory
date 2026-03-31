using UnityEngine;

public class st : MonoBehaviour
{
    public GameObject objectToActivate; // Объект для активации

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("st")) // Проверка на тег "heart"
        {
            objectToActivate.SetActive(true); // Активация объекта

            Destroy(other.gameObject); // Удаление объекта с тегом "heart"

        }
    }
}
