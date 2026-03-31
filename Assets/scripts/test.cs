using System.Collections;
using UnityEngine;

public class test : MonoBehaviour
{
    public AudioClip soundClip; // Звуковой клип
    public GameObject prefab; // Префаб
    public GameObject emptyObject; // Пустой объект

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PlaySoundAndInstantiatePrefab());
        }
    }

    IEnumerator PlaySoundAndInstantiatePrefab()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip;
        audioSource.Play(); // Воспроизводим звук

        yield return new WaitForSeconds(5); // Ждем 5 секунд

        Instantiate(prefab, emptyObject.transform.position, Quaternion.identity); // Создаем префаб на пустом объекте на сцене
    }
}
