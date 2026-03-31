using UnityEngine;

public class glaz : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToHide;
    public bool activated = false;
    public string objectTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(objectTag))
        {
            activated = true;

            objectToActivate.SetActive(true);

            Destroy(other.gameObject);

        }
        if (activated == true)
        {
            objectToHide.SetActive(false);
        }
    }
}
