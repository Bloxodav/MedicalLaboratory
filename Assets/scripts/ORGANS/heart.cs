using UnityEngine;

public class heart : MonoBehaviour
{
    public GameObject objectToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("brain"))
        {
            objectToActivate.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
