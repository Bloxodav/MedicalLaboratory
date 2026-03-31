using UnityEngine;

public class black_guy : MonoBehaviour
{
    public GameObject objectToActivate; // Объект для активации

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("kid")) // Проверка на тег "heart"
        {
            objectToActivate.SetActive(true); // Активация объекта

            Destroy(other.gameObject); // Удаление объекта с тегом "heart"
            
        }
    }
}
